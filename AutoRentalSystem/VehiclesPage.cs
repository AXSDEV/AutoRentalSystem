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
                    BeginInvoke(new Action(LoadVehiclesFromFile));
                }
            }
        }

        private void VehiclesPage_Load(object sender, EventArgs e)
        {
            if (_samplesLoaded) return;

            LoadVehiclesFromFile();
            _samplesLoaded = true;
        }

        private void LoadVehiclesFromFile()
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

            var vehicles = CsvExportService.ImportVehicles(_vehiclesFilePath);

            int added = 0;
            foreach (var vehicle in vehicles)
            {
                if (vehicle == null) continue;
                flowpanel_list.Controls.Add(new VehicleCards(vehicle));
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
    }
}
