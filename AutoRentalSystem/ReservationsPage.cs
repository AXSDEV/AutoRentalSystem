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
    public partial class ReservationsPage_Background : UserControl
    {
        private readonly string _vehiclesFilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "data",
            "vehicles.csv");

        private readonly string _reservationsFilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "data",
            "reservations.csv");

        private bool _samplesLoaded;
        public ReservationsPage_Background()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        private void ReservationsPage_Load(object sender, EventArgs e)
        {
            if (_samplesLoaded) return;

            LoadReservationsFromFile();
            _samplesLoaded = true;
        }

        private void LoadReservationsFromFile()
        {
            if (!File.Exists(_vehiclesFilePath))
            {
                MessageBox.Show(
                    $"CSV not found:\n{_vehiclesFilePath}",
                    "Vehicle Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(_reservationsFilePath))
            {
                MessageBox.Show(
                    $"CSV not found:\n{_reservationsFilePath}",
                    "Reservations Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var vehicles = CsvExportService.ImportVehicles(_vehiclesFilePath);

            ReservationManager.LoadReservationsFromFile(vehicles, _reservationsFilePath);

            flowLayoutPanel_reservations.Controls.Clear();

            foreach (var reservation in ReservationManager.Reservations)
            {
                var card = new VehicleCards();
                card.BindReservation(reservation);
                flowLayoutPanel_reservations.Controls.Add(card);
            }
        }


        private void RenderReservations()
        {
            flowLayoutPanel_reservations.Controls.Clear();

            foreach (var r in ReservationManager.Reservations)
            {
                var card = new VehicleCards();
                card.BindReservation(r);
                flowLayoutPanel_reservations.Controls.Add(card);
            }
        }
    }

}
