using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace AutoRentalSystem
{
    public partial class VehicleCards : UserControl
    {
        private Vehicle _vehicle;
        private Reservation _reservation;
        // Indica se o cartão está a representar uma reserva ou um veículo
        private bool _isReservationCard;

        // Modo do card vai depender da página onde está a ser usado
        private CardMode _mode = CardMode.VehiclesPage;

        // Controlo com os botões/ações
        private Control _actionsControl;

        // Eventos usados para quando o utilizador pede uma ação sobre um veículo
        public event EventHandler<VehicleEventArgs> ReserveRequested;
        public event EventHandler<VehicleEventArgs> EditRequested;
        public event EventHandler<VehicleEventArgs> DeleteRequested;
        public event EventHandler<VehicleEventArgs> AlterStateRequested;

        // Evento usado para avisar que foi criada uma nova reserva
        public event EventHandler ReservationCreated;

        // Eventos usados para pedir ações sobre uma reserva (editar/apagar)
        public event EventHandler<ReservationEventArgs> ReservationEditRequested;
        public event EventHandler<ReservationEventArgs> ReservationDeleteRequested;

        // Enum para indicar o contexto/página onde o cartão está a ser apresentado
        public enum CardMode
        {
            VehiclesPage,
            ReservationsPage,
            MaintenancePage
        }

        public VehicleCards()
        {
            InitializeComponent();
            // Define o cursor para o elemento ser clicável
            Cursor = Cursors.Hand;
            default_card_panel.Cursor = Cursors.Hand;

            // Associa eventos de clique e efeitos de hover
            default_card_panel.Click += default_card_panel_Click;
            default_card_panel.Click -= default_card_panel_Click;
            default_card_panel.MouseEnter += default_card_panel_MouseEnter;
            default_card_panel.MouseLeave += default_card_panel_MouseLeave;

            // Permite clicar também nas labels para abrir detalhes
            label1.Click += default_card_panel_Click;
            label2.Click += default_card_panel_Click;
            label3.Click += default_card_panel_Click;
            label4.Click += default_card_panel_Click;
            label5.Click += default_card_panel_Click;
            label6.Click += default_card_panel_Click;
        }

        // Construtor para criar cartão já associado a um veículo (modo VehiclesPage)
        public VehicleCards(Vehicle vehicle) : this()
        {
            _mode = CardMode.VehiclesPage;
            BindVehicle(vehicle);
        }

        // Construtor para criar cartão associado a um veículo e a um modo específico
        public VehicleCards(Vehicle vehicle, CardMode mode) : this()
        {
            _mode = mode;
            BindVehicle(vehicle);
        }

        // Preenche o cartão com os dados de um veículo
        public void BindVehicle(Vehicle vehicle)
        {
            if (vehicle == null) return;

            _isReservationCard = false;
            _reservation = null;
            _vehicle = vehicle;

            // Cria/mostra os botões corretos conforme o modo
            EnsureActionsControl(_mode);

            pictureBox_RentState.Image = GetRentStateIcon(vehicle.RentState);

            label1.Text = vehicle.LicensePlate;
            label2.Text = vehicle.VehicleType;
            label3.Text = vehicle.Maker;
            label4.Text = vehicle.Model;

            // No modo manutenção, mostra datas de manutenção
            if (_mode == CardMode.MaintenancePage)
            {
                label5.Text = vehicle.MaintenanceStartDate.HasValue
                    ? vehicle.MaintenanceStartDate.Value.ToString("yyyy-MM-dd")
                    : "—";

                label6.Text = vehicle.MaintenanceEndDate.HasValue
                    ? vehicle.MaintenanceEndDate.Value.ToString("yyyy-MM-dd")
                    : "—";

                // Diferencia manutenção agendada vs em curso pelo ícone
                bool onGoing = vehicle.IsInMaintenance(AppClock.Today);
                pictureBox_RentState.Image = onGoing
                    ? Properties.Resources.state_maintenance   // On Going: ícone vermelho
                    : Properties.Resources.state_reserved;       // Scheduled: ícone amarelo
            }
            else // Nos outros modos, mostra ano e preço por dia
            {
                label5.Text = vehicle.Year.ToString();
                label6.Text = vehicle.DailyPrice.ToString("C", new CultureInfo("pt-PT"));
            }
        }

        // Preenche o cartão com os dados de uma reserva
        public void BindReservation(Reservation reservation)
        {
            if (reservation == null) return;

            _isReservationCard = true;
            _reservation = reservation;
            _vehicle = reservation.Vehicle;

            reservation.UpdateStatus(AppClock.Today);

            // No modo reservas, mostra os botões de editar/apagar reserva
            EnsureActionsControl(CardMode.ReservationsPage);

            label1.Text = _vehicle?.LicensePlate ?? "—";
            label2.Text = _vehicle?.VehicleType ?? "—";
            label3.Text = reservation.StartDate.ToString("yyyy-MM-dd");
            label4.Text = reservation.EndDate.ToString("yyyy-MM-dd");
            label5.Text = reservation.TotalPrice.ToString("C", new CultureInfo("pt-PT"));
            label6.Text = GetReservationStatusLabel(reservation.Status);

            pictureBox_RentState.Image = GetReservationStatusIcon(reservation.Status);
        }

        // Devolve o texto do estado da reserva para mostrar no cartão
        private static string GetReservationStatusLabel(ReservationStatus status)
        {
            switch (status)
            {
                case ReservationStatus.Active:
                    return "Rented";
                case ReservationStatus.Completed:
                    return "Completed";
                default:
                    return "Reserved";
            }
        }

        // Devolve o ícone conforme o estado da reserva
        private static Image GetReservationStatusIcon(ReservationStatus status)
        {
            switch (status)
            {
                case ReservationStatus.Active:
                    return Properties.Resources.state_rented;
                case ReservationStatus.Completed:
                    return Properties.Resources.state_available;
                default:
                    return Properties.Resources.state_reserved;
            }
        }

        // Cria o controlo de ações (botões) conforme a página/modo do cartão
        private void EnsureActionsControl(CardMode mode)
        {
            if (panel_actions == null) return;

            _mode = mode;

            panel_actions.Controls.Clear();
            _actionsControl?.Dispose();
            _actionsControl = null;

            // Define os botões conforme o modo
            if (mode == CardMode.VehiclesPage)
            {
                var actions = new UC_VehicleCards_VehiclesPage();

                actions.ReserveClicked += (_, __) => BtnReserve_Click();
                actions.EditClicked += (_, __) => BtnEdit_Click();
                actions.DeleteClicked += (_, __) => BtnDelete_Click();
                actions.AlterStateClicked += (_, __) => BtnAlterState_Click();

                _actionsControl = actions;
            }
            else if (mode == CardMode.MaintenancePage)
            {
                var actions = new UC_VehicleCards_MaintenancePage();

                actions.AlterStateClicked += (_, __) => BtnAlterState_Click();

                _actionsControl = actions;
            }
            else
            {
                var actions = new UC_VehicleCards_ReservationPage();

                actions.EditClicked += (_, __) => BtnEdit_Click();
                actions.DeleteClicked += (_, __) => BtnDelete_Click();

                _actionsControl = actions;
            }

            if (_actionsControl == null) return;

            // Adiciona os botões ao painel
            _actionsControl.Dock = DockStyle.Fill;
            panel_actions.Controls.Add(_actionsControl);
        }

        // Abre o formulário para reservar o veículo
        private void BtnReserve_Click()
        {
            if (_vehicle == null) return;

            // Impede reservar se o veículo estiver em manutenção
            if (string.Equals(_vehicle.RentState, "Maintenance", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "This vehicle is in maintenance and cannot be reserved.",
                    "Reservation unavailable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            // Mostra o formulário de reserva e avisa a página se a reserva foi criada
            using (var form = new ReserveVehicleForm(_vehicle))
            {
                form.StartPosition = FormStartPosition.CenterParent;
                var result = form.ShowDialog(FindForm());
                if (result == DialogResult.OK)
                    ReservationCreated?.Invoke(this, EventArgs.Empty);
            }
        }

        // Pede edição do veículo ou da reserva (depende do modo)
        private void BtnEdit_Click()
        {
            if (_mode == CardMode.ReservationsPage)
            {
                if (_reservation == null) return;
                ReservationEditRequested?.Invoke(this, new ReservationEventArgs(_reservation));
                return;
            }

            if (_vehicle == null) return;
            EditRequested?.Invoke(this, new VehicleEventArgs(_vehicle));
        }

        // Pede remoção do veículo ou da reserva (depende do modo)
        private void BtnDelete_Click()
        {
            if (_mode == CardMode.ReservationsPage)
            {
                if (_reservation == null) return;
                ReservationDeleteRequested?.Invoke(this, new ReservationEventArgs(_reservation));
                return;
            }

            if (_vehicle == null) return;
            DeleteRequested?.Invoke(this, new VehicleEventArgs(_vehicle));
        }

        // Pede alteração do estado do veículo
        private void BtnAlterState_Click()
        {
            if (_mode == CardMode.ReservationsPage) return;

            if (_vehicle == null) return;

            AlterStateRequested?.Invoke(this, new VehicleEventArgs(_vehicle));
        }

        // Abre a janela com os detalhes do veículo ao clicar no cartão
        private void default_card_panel_Click(object sender, EventArgs e)
        {
            if (_vehicle == null) return;

            using (var details = new VehicleDetailsForm(_vehicle))
            {
                details.StartPosition = FormStartPosition.CenterParent;
                details.ShowDialog(FindForm());
            }
        }

        // Efeito visual ao passar o rato por cima do cartão
        private void default_card_panel_MouseEnter(object sender, EventArgs e)
            => default_card_panel.FillColor = Color.FromArgb(45, 45, 60);

        private void default_card_panel_MouseLeave(object sender, EventArgs e)
            => default_card_panel.FillColor = Color.FromArgb(34, 33, 42);
        
        // Devolve o ícone correspondente ao estado do veículo
        private Image GetRentStateIcon(string rentState)
        {
            var state = (rentState ?? string.Empty).Trim().ToLowerInvariant();

            switch (state)
            {
                case "available": return Properties.Resources.state_available;
                case "reserved": return Properties.Resources.state_reserved;
                case "rented": return Properties.Resources.state_rented;
                case "maintenance": return Properties.Resources.state_maintenance;
                default: return null;
            }
        }

        // Classe usada para enviar o veículo nos eventos
        public class VehicleEventArgs : EventArgs
        {
            public VehicleEventArgs(Vehicle vehicle) => Vehicle = vehicle;
            public Vehicle Vehicle { get; }
        }
        
        // Classe usada para enviar a reserva nos eventos
        public class ReservationEventArgs : EventArgs
        {
            public ReservationEventArgs(Reservation reservation) => Reservation = reservation;
            public Reservation Reservation { get; }
        }
    }
}