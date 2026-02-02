using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace AutoRentalSystem
{
    public partial class VehiclesPage : UserControl
    {
        private List<Vehicle> _allVehicles = new List<Vehicle>();

        private readonly string _vehiclesFilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "data",
            "vehicles.csv");

        public VehiclesPage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.AutoScroll = false;
        }

        private void btn_addvehicle_Click(object sender, EventArgs e)
        {
            using (var form = new VehicleAddForm())
            {
                form.StartPosition = FormStartPosition.CenterParent;

                var result = form.ShowDialog(FindForm());

                if (result == DialogResult.OK)
                {
                    BeginInvoke(new Action(RefreshVehicles));
                }
            }
        }

        private void VehiclesPage_Load(object sender, EventArgs e)
        {
            textBox_search.TextChanged += (_, __) => ApplyFilters();
            comboBox_status.SelectedIndexChanged += (_, __) => ApplyFilters();
            comboBox_vehicleType.SelectedIndexChanged += (_, __) => ApplyFilters();

            RefreshVehicles();
        }

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

            RenderVehicles(query.ToList());
        }

        private string NormalizePlate(string s)
        {
            return (s ?? "").Replace(" ", "").Replace("-", "").Trim();
        }


        private void RenderVehicles(List<Vehicle> vehicles)
        {
            flowpanel_list.SuspendLayout();
            flowpanel_list.Controls.Clear();

            foreach (var vehicle in vehicles)
            {
                var card = new VehicleCards(vehicle);
                card.DeleteRequested += HandleDeleteVehicle;
                card.EditRequested += HandleEditVehicle;
                card.AlterStateRequested += HandleAlterStateVehicle;
                flowpanel_list.Controls.Add(card);
            }

            flowpanel_list.ResumeLayout(true);
        }

        private bool MatchesType(Vehicle v, string type)
        {
            return v.GetType().Name.Equals(type, StringComparison.OrdinalIgnoreCase);
        }

        public void RefreshVehicles()
        {
            if (!File.Exists(_vehiclesFilePath))
            {
                _allVehicles = new List<Vehicle>();
                MessageBox.Show(
                    $"CSV not found:\n{_vehiclesFilePath}",
                    "Vehicle data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                ApplyFilters(); // limpa a UI
                return;
            }

            Enterprise.Instance.LoadVehiclesFromCsv(_vehiclesFilePath);
            Enterprise.Instance.UpdateMaintenanceStates(AppClock.Today);
            // guarda a lista base em memória
            _allVehicles = Enterprise.Instance.Vehicles
                .Where(v => v != null)
                .ToList();

            // aplica filtros e desenha
            ApplyFilters();
        }

        private void HandleDeleteVehicle(object sender, VehicleCards.VehicleEventArgs e)
        {
            if (e?.Vehicle == null)
            {
                return;
            }

            var confirm = MessageBox.Show(
                $"Delete vehicle {e.Vehicle.LicensePlate}?",
                "Delete vehicle",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            if (File.Exists(_vehiclesFilePath))
            {
                Enterprise.Instance.LoadVehiclesFromCsv(_vehiclesFilePath);
            }

            if (!Enterprise.Instance.RemoveVehicle(e.Vehicle.LicensePlate))
            {
                MessageBox.Show(
                    "Vehicle not found.",
                    "Delete vehicle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            EnsureVehiclesDirectory();
            Enterprise.Instance.SaveVehiclesToCsv(_vehiclesFilePath);
            RefreshVehicles();
        }

        private void HandleEditVehicle(object sender, VehicleCards.VehicleEventArgs e)
        {
            if (e?.Vehicle == null)
            {
                return;
            }

            using (var form = new VehicleAddForm(e.Vehicle))
            {
                form.StartPosition = FormStartPosition.CenterParent;
                var result = form.ShowDialog(FindForm());
                if (result == DialogResult.OK)
                {
                    RefreshVehicles();
                }
            }
        }

        private void HandleAlterStateVehicle(object sender, VehicleCards.VehicleEventArgs e)
        {
            if (e == null || e.Vehicle == null)
                return;

            using (var form = new AlterStateForm(
                e.Vehicle.RentState,
                e.Vehicle.MaintenanceStartDate,
                e.Vehicle.MaintenanceEndDate))
            {
                form.StartPosition = FormStartPosition.CenterParent;

                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                e.Vehicle.RentState = form.SelectedState;

                if (form.SelectedState == "Maintenance")
                {
                    e.Vehicle.MaintenanceStartDate = form.MaintenanceStartDate;
                    e.Vehicle.MaintenanceEndDate = form.MaintenanceEndDate;
                    e.Vehicle.AvailabilityDate = null;
                }
                else
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

        private void EnsureVehiclesDirectory()
        {
            var directory = Path.GetDirectoryName(_vehiclesFilePath);
            if (!string.IsNullOrWhiteSpace(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }
    }
}
