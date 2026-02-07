using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace AutoRentalSystem
{
    public partial class VehiclesPage : UserControl
    {        
        // Lista com todos os veículos carregados do ficheiro
        private List<Vehicle> _allVehicles = new List<Vehicle>();

        private readonly string _vehiclesFilePath = AppPaths.VehiclesFilePath;

        public VehiclesPage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.AutoScroll = false;
        }

        // Abre o formulário para adicionar um novo veículo
        private void btn_addvehicle_Click(object sender, EventArgs e)
        {
            using (var form = new VehicleAddForm())
            {
                form.StartPosition = FormStartPosition.CenterParent;

                var result = form.ShowDialog(FindForm());

                // Se o utilizador confirmar, atualiza a lista
                if (result == DialogResult.OK)
                {
                    BeginInvoke(new Action(RefreshVehicles));
                }
            }
        }

        private void VehiclesPage_Load(object sender, EventArgs e)
        {            
            // Associa eventos de filtros (pesquisa, estado e tipo)
            textBox_search.TextChanged += (_, __) => ApplyFilters();
            comboBox_status.SelectedIndexChanged += (_, __) => ApplyFilters();
            comboBox_vehicleType.SelectedIndexChanged += (_, __) => ApplyFilters();

            // Atualiza a página quando a data simulada muda
            AppClock.DateChanged += OnAppDateChanged;

            RefreshVehicles();
        }

        // Atualiza a página quando a data do sistema/simulador muda
        private void OnAppDateChanged(DateTime newDate)
        {
            // Evita atualizar se o controlo já foi destruído
            if (IsDisposed || !IsHandleCreated) return;
            BeginInvoke(new Action(RefreshVehicles));
        }

        // Aplica os filtros de pesquisa, estado e tipo à lista de veículos
        private void ApplyFilters()
        {
            IEnumerable<Vehicle> query = _allVehicles;

            // SEARCH
            string q = textBox_search.Text.Trim();
            if (!string.IsNullOrEmpty(q))
            {
                string norm = NormalizePlate(q);
                query = query.Where(v =>
                    !string.IsNullOrEmpty(v.LicensePlate) &&
                    NormalizePlate(v.LicensePlate).IndexOf(norm, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            // STATUS
            string status = comboBox_status.SelectedItem != null ? comboBox_status.SelectedItem.ToString() : "All";
            if (!status.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                query = query.Where(v =>
                    string.Equals(v.RentState, status, StringComparison.OrdinalIgnoreCase));
            }

            // TYPE
            string type = comboBox_vehicleType.SelectedItem != null ? comboBox_vehicleType.SelectedItem.ToString() : "All";
            if (!type.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                query = query.Where(v =>
                    v.GetType().Name.Equals(type, StringComparison.OrdinalIgnoreCase));
            }

            // Mostra os veículos filtrados
            RenderVehicles(query.ToList());
        }

        // Normaliza o texto da matrícula (remove espaços e hífens)
        private string NormalizePlate(string s)
        {
            return (s ?? "").Replace(" ", "").Replace("-", "").Trim();
        }

        // Cria e mostra os cartões (VehicleCards) no painel
        private void RenderVehicles(List<Vehicle> vehicles)
        {
            flowpanel_list.SuspendLayout();
            flowpanel_list.Controls.Clear();

            foreach (var vehicle in vehicles)
            {
                // Cria um cartão para cada veículo
                var card = new VehicleCards(vehicle);

                // Associa eventos aos botões do cartão
                card.DeleteRequested += HandleDeleteVehicle;
                card.EditRequested += HandleEditVehicle;
                card.AlterStateRequested += HandleAlterStateVehicle;

                // Quando uma reserva é criada, atualiza a lista
                card.ReservationCreated += (s, e) => RefreshVehicles();

                flowpanel_list.Controls.Add(card);
            }

            flowpanel_list.ResumeLayout(true);
        }

        // Verifica se um veículo corresponde a um tipo (não está a ser usado neste ficheiro)
        private bool MatchesType(Vehicle v, string type)
        {
            return v.GetType().Name.Equals(type, StringComparison.OrdinalIgnoreCase);
        }

        // Recarrega os veículos do CSV e atualiza o ecrã
        public void RefreshVehicles()
        {
            if (!File.Exists(_vehiclesFilePath))
            {
                _allVehicles.Clear();
                flowpanel_list.Controls.Clear();
                return;
            }

            // Carrega veículos e atualiza estados (manutenção e aluguer/reserva)
            Enterprise.Instance.LoadVehiclesFromCsv(_vehiclesFilePath);
            Enterprise.Instance.UpdateMaintenanceStates(AppClock.Today);
            ReservationManager.UpdateAllVehicleStatesFromReservations(Enterprise.Instance.Vehicles);
            // guarda a lista 
            _allVehicles = Enterprise.Instance.Vehicles
                .Where(v => v != null)
                .ToList();

            // aplica filtros
            ApplyFilters();
        }

        // Trata o pedido de apagar veículo vindo do cartão
        private void HandleDeleteVehicle(object sender, VehicleCards.VehicleEventArgs e)
        {
            if (e?.Vehicle == null)
            {
                return;
            }
            // Confirmação antes de apagar
            var confirm = MessageBox.Show(
                $"Delete vehicle {e.Vehicle.LicensePlate}?",
                "Delete vehicle",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }
            // Recarrega o ficheiro para garantir dados atualizados
            if (File.Exists(_vehiclesFilePath))
            {
                Enterprise.Instance.LoadVehiclesFromCsv(_vehiclesFilePath);
            }
            // Remove o veículo pela matrícula
            if (!Enterprise.Instance.RemoveVehicle(e.Vehicle.LicensePlate))
            {
                MessageBox.Show(
                    "Vehicle not found.",
                    "Delete vehicle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            // Guarda alterações e atualiza o ecrã
            Directory.CreateDirectory(AppPaths.DataFolder);
            Enterprise.Instance.SaveVehiclesToCsv(_vehiclesFilePath);
            RefreshVehicles();
        }

        // Trata o pedido de editar veículo vindo do cartão
        private void HandleEditVehicle(object sender, VehicleCards.VehicleEventArgs e)
        {
            if (e?.Vehicle == null)
            {
                return;
            }

            // Abre formulário com dados do veículo para edição
            using (var form = new VehicleAddForm(e.Vehicle))
            {
                form.StartPosition = FormStartPosition.CenterParent;
                var result = form.ShowDialog(FindForm());
                // Se confirmar, atualiza a lista
                if (result == DialogResult.OK)
                {
                    RefreshVehicles();
                }
            }
        }

        // Trata o pedido de alterar estado do veículo
        private void HandleAlterStateVehicle(object sender, VehicleCards.VehicleEventArgs e)
        {
            if (e == null || e.Vehicle == null)
                return;

            // Abre o formulário para escolher o novo estado e datas de manutenção
            using (var form = new AlterStateForm(
                e.Vehicle.RentState,
                e.Vehicle.MaintenanceStartDate,
                e.Vehicle.MaintenanceEndDate))
            {
                form.StartPosition = FormStartPosition.CenterParent;

                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                e.Vehicle.RentState = form.SelectedState;

                // Se entrar em manutenção, guarda datas e limpa disponibilidade
                if (form.SelectedState == "Maintenance")
                {
                    e.Vehicle.MaintenanceStartDate = form.MaintenanceStartDate;
                    e.Vehicle.MaintenanceEndDate = form.MaintenanceEndDate;
                    e.Vehicle.AvailabilityDate = null;
                }
                else  // Se sair de manutenção, limpa as datas

                {
                    e.Vehicle.MaintenanceStartDate = null;
                    e.Vehicle.MaintenanceEndDate = null;
                    e.Vehicle.AvailabilityDate = null;
                }

                Enterprise.Instance.UpdateMaintenanceStates(AppClock.Today);

                Enterprise.Instance.SaveVehiclesToCsv(_vehiclesFilePath);
                RefreshVehicles();
            }
        }

        // Remove o evento da data ao destruir a página
        protected override void OnHandleDestroyed(EventArgs e)
        {
            AppClock.DateChanged -= OnAppDateChanged;
            base.OnHandleDestroyed(e);
        }
    }
}
 