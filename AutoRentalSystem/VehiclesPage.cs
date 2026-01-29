using System;
using System.IO;
using System.Windows.Forms;

namespace AutoRentalSystem
{
    public partial class VehiclesPage : UserControl
    {
        private readonly string _vehiclesFilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "data",
            "vehicles.csv");

        private bool _samplesLoaded;

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
                    BeginInvoke(new Action(LoadVehiclesFromEnterprise));
                }
            }
        }

        private void VehiclesPage_Load(object sender, EventArgs e)
        {
            if (_samplesLoaded) return;

            LoadVehiclesFromEnterprise();
            _samplesLoaded = true;
        }
        public void RefreshVehicles()
        {
            LoadVehiclesFromEnterprise();
        }
        private void LoadVehiclesFromEnterprise()
        {
            if (flowpanel_list == null)
            {
                MessageBox.Show("flowpanel_list é null (Designer / Name errado).");
                return;
            }

            flowpanel_list.SuspendLayout();
            flowpanel_list.Controls.Clear();

            if (!File.Exists(_vehiclesFilePath))
            {
                flowpanel_list.ResumeLayout();
                MessageBox.Show(
                    $"CSV não encontrado:\n{_vehiclesFilePath}",
                    "Dados de veículos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Enterprise.Instance.LoadVehiclesFromCsv(_vehiclesFilePath);
            var vehicles = Enterprise.Instance.Vehicles;

            int added = 0;
            foreach (var vehicle in vehicles)  
            {
                if (vehicle == null) continue;
                var card = new VehicleCards(vehicle);
                card.DeleteRequested += HandleDeleteVehicle;
                card.EditRequested += HandleEditVehicle;
                flowpanel_list.Controls.Add(card);
                added++;
            }

            flowpanel_list.ResumeLayout(true);

            // força redesenho
            flowpanel_list.PerformLayout();
            flowpanel_list.Invalidate();
            flowpanel_list.Update();
            this.Invalidate();
            this.Update();

            //MessageBox.Show($"Recarregado em runtime: {added} veículos.", "DEBUG");
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
            LoadVehiclesFromEnterprise();
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
                    LoadVehiclesFromEnterprise();
                }
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
