using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace AutoRentalSystem
{
    public partial class MaintenancePage : UserControl
    {
        private List<Vehicle> _allVehicles = new List<Vehicle>();

        private readonly string _vehiclesFilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "data",
            "vehicles.csv");

        public MaintenancePage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void MaintenancePage_Load(object sender, EventArgs e)
        {
            textBox_search.TextChanged += (_, __) => ApplyFilters();

            RefreshVehicles();
        }

        public void RefreshVehicles()
        {
            if (!File.Exists(_vehiclesFilePath))
            {
                _allVehicles = new List<Vehicle>();
                flowLayoutPanel_maintenance.Controls.Clear();
                return;
            }

            Enterprise.Instance.LoadVehiclesFromCsv(_vehiclesFilePath);

            _allVehicles = Enterprise.Instance.GetVehiclesInMaintenance()
                .Where(v => v != null)
                .ToList();

            ApplyFilters();
        }

        private void ApplyFilters()
        {
            IEnumerable<Vehicle> query = _allVehicles;

            // SEARCH por matrícula
            string q = textBox_search.Text.Trim();
            if (!string.IsNullOrEmpty(q))
            {
                string norm = NormalizePlate(q);
                query = query.Where(v =>
                    !string.IsNullOrEmpty(v.LicensePlate) &&
                    NormalizePlate(v.LicensePlate).IndexOf(norm, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            RenderVehicles(query.ToList());
        }

        private string NormalizePlate(string s)
        {
            return (s ?? "").Replace(" ", "").Replace("-", "").Trim();
        }

        private void RenderVehicles(List<Vehicle> vehicles)
        {
            flowLayoutPanel_maintenance.SuspendLayout();
            flowLayoutPanel_maintenance.Controls.Clear();

            foreach (var vehicle in vehicles)
            {
                var card = new VehicleCards(vehicle, VehicleCards.CardMode.MaintenancePage);
                card.AlterStateRequested += HandleAlterStateVehicle;
                flowLayoutPanel_maintenance.Controls.Add(card);
            }

            flowLayoutPanel_maintenance.ResumeLayout(true);
        }
        private void HandleAlterStateVehicle(object sender, VehicleCards.VehicleEventArgs e)
        {
            if (e?.Vehicle == null)
            {
                return;
            }

            using (var form = new AlterStateForm(
                e.Vehicle.RentState,
                e.Vehicle.MaintenanceStartDate,
                e.Vehicle.MaintenanceEndDate))
            {
                form.StartPosition = FormStartPosition.CenterParent;

                if (form.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

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
                EnsureVehiclesDirectory();
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