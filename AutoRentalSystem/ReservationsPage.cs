using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutoRentalSystem
{
    public partial class ReservationsPage_Background : UserControl
    {
        private List<Reservation> _allReservations = new List<Reservation>();

        public ReservationsPage_Background()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void ReservationsPage_Load(object sender, EventArgs e)
        {
            if (textBox_search != null)
                textBox_search.TextChanged += (_, __) => ApplyFilters();

            ReservationManager.ReservationsChanged += OnReservationsChanged;

            RefreshReservations();
        }

        private void OnReservationsChanged()
        {
            if (IsDisposed) return;

            if (InvokeRequired)
            {
                BeginInvoke(new Action(RefreshReservations)); 
                return;
            }

            RefreshReservations();
        }

        private void RefreshReservations()
        {
            _allReservations = ReservationManager.Reservations
                .Where(r => r != null)
                .ToList();

            ApplyFilters();
        }

        private void ApplyFilters()
        {
            IEnumerable<Reservation> query = _allReservations;

            // SEARCH por matrícula do veículo na reserva
            string q = (textBox_search?.Text ?? string.Empty).Trim();
            if (!string.IsNullOrEmpty(q))
            {
                string norm = NormalizePlate(q);
                query = query.Where(r =>
                    r.Vehicle != null &&
                    !string.IsNullOrEmpty(r.Vehicle.LicensePlate) &&
                    NormalizePlate(r.Vehicle.LicensePlate)
                        .IndexOf(norm, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            RenderReservations(query.ToList());
        }

        private static string NormalizePlate(string s)
        {
            return (s ?? string.Empty).Replace(" ", "").Replace("-", "").Trim();
        }

        private void RenderReservations()
        {
            RenderReservations(_allReservations);
        }

        private void RenderReservations(List<Reservation> reservations)
        {
            if (flowLayoutPanel_reservations == null) return;

            flowLayoutPanel_reservations.SuspendLayout();
            flowLayoutPanel_reservations.Controls.Clear();

            foreach (var r in reservations)
            {
                var card = new VehicleCards();
                card.BindReservation(r);
                flowLayoutPanel_reservations.Controls.Add(card);
            }

            flowLayoutPanel_reservations.ResumeLayout(true);
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            ReservationManager.ReservationsChanged -= OnReservationsChanged;
            base.OnHandleDestroyed(e);
        }
    }
}
