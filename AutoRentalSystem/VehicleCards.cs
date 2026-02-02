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
        private bool _isReservationCard;
        private CardMode _mode = CardMode.VehiclesPage;
        private Control _actionsControl;

        public event EventHandler<VehicleEventArgs> ReserveRequested;
        public event EventHandler<VehicleEventArgs> EditRequested;
        public event EventHandler<VehicleEventArgs> DeleteRequested;
        public event EventHandler<VehicleEventArgs> AlterStateRequested;
       
        public event EventHandler ReservationCreated;

        public event EventHandler<ReservationEventArgs> ReservationEditRequested;
        public event EventHandler<ReservationEventArgs> ReservationDeleteRequested;

        public enum CardMode
        {
            VehiclesPage,
            ReservationsPage,
            MaintenancePage
        }

        public VehicleCards()
        {
            InitializeComponent();

            Cursor = Cursors.Hand;
            default_card_panel.Cursor = Cursors.Hand;

            default_card_panel.Click += default_card_panel_Click;
            default_card_panel.Click -= default_card_panel_Click;
            default_card_panel.MouseEnter += default_card_panel_MouseEnter;
            default_card_panel.MouseLeave += default_card_panel_MouseLeave;

            label1.Click += default_card_panel_Click;
            label2.Click += default_card_panel_Click;
            label3.Click += default_card_panel_Click;
            label4.Click += default_card_panel_Click;
            label5.Click += default_card_panel_Click;
            label6.Click += default_card_panel_Click;
        }

        public VehicleCards(Vehicle vehicle) : this()
        {
            _mode = CardMode.VehiclesPage;
            BindVehicle(vehicle);
        }

        public VehicleCards(Vehicle vehicle, CardMode mode) : this()
        {
            _mode = mode;
            BindVehicle(vehicle);
        }

        public void BindVehicle(Vehicle vehicle)
        {
            if (vehicle == null) return;

            _isReservationCard = false;
            _reservation = null;
            _vehicle = vehicle;

            EnsureActionsControl(_mode);

            pictureBox_RentState.Image = GetRentStateIcon(vehicle.RentState);

            label1.Text = vehicle.LicensePlate;
            label2.Text = vehicle.VehicleType;
            label3.Text = vehicle.Maker;
            label4.Text = vehicle.Model;

            if (_mode == CardMode.MaintenancePage)
            {
                label5.Text = vehicle.MaintenanceStartDate.HasValue
                    ? vehicle.MaintenanceStartDate.Value.ToString("yyyy-MM-dd")
                    : "—";

                label6.Text = vehicle.MaintenanceEndDate.HasValue
                    ? vehicle.MaintenanceEndDate.Value.ToString("yyyy-MM-dd")
                    : "—";

                // Scheduled = amarelo (legend: Scheduled). On Going = laranja/vermelho (legend: On Going)
                bool onGoing = vehicle.IsInMaintenance(AppClock.Today);
                pictureBox_RentState.Image = onGoing
                    ? Properties.Resources.state_maintenance   // On Going: ícone vermelho/laranja
                    : Properties.Resources.state_reserved;       // Scheduled: ícone amarelo
            }
            else
            {
                label5.Text = vehicle.Year.ToString();
                label6.Text = vehicle.DailyPrice.ToString("C", new CultureInfo("pt-PT"));
            }
        }

        public void BindReservation(Reservation reservation)
        {
            if (reservation == null) return;

            _isReservationCard = true;
            _reservation = reservation;
            _vehicle = reservation.Vehicle;

            reservation.UpdateStatus(AppClock.Today);

            EnsureActionsControl(CardMode.ReservationsPage);

            label1.Text = _vehicle?.LicensePlate ?? "—";
            label2.Text = _vehicle?.VehicleType ?? "—";
            label3.Text = reservation.StartDate.ToString("yyyy-MM-dd");
            label4.Text = reservation.EndDate.ToString("yyyy-MM-dd");
            label5.Text = reservation.TotalPrice.ToString("C", new CultureInfo("pt-PT"));
            label6.Text = GetReservationStatusLabel(reservation.Status);

            pictureBox_RentState.Image = GetReservationStatusIcon(reservation.Status);
        }

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

        private void EnsureActionsControl(CardMode mode)
        {
            if (panel_actions == null) return;

            _mode = mode;

            panel_actions.Controls.Clear();
            _actionsControl?.Dispose();
            _actionsControl = null;

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

            _actionsControl.Dock = DockStyle.Fill;
            panel_actions.Controls.Add(_actionsControl);
        }

        private void BtnReserve_Click()
        {
            if (_vehicle == null) return;

            // Nota: tu usas strings ("Maintenance", "available"...). Mantive.
            if (string.Equals(_vehicle.RentState, "Maintenance", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "This vehicle is in maintenance and cannot be reserved.",
                    "Reservation unavailable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            using (var form = new ReserveVehicleForm(_vehicle))
            {
                form.StartPosition = FormStartPosition.CenterParent;
                var result = form.ShowDialog(FindForm());
                if (result == DialogResult.OK)
                    ReservationCreated?.Invoke(this, EventArgs.Empty);
            }
        }

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

        private void BtnAlterState_Click()
        {
            if (_mode == CardMode.ReservationsPage) return;

            if (_vehicle == null) return;

            AlterStateRequested?.Invoke(this, new VehicleEventArgs(_vehicle));
        }

        private void default_card_panel_Click(object sender, EventArgs e)
        {
            if (_vehicle == null) return;

            using (var details = new VehicleDetailsForm(_vehicle))
            {
                details.StartPosition = FormStartPosition.CenterParent;
                details.ShowDialog(FindForm());
            }
        }

        private void default_card_panel_MouseEnter(object sender, EventArgs e)
            => default_card_panel.FillColor = Color.FromArgb(45, 45, 60);

        private void default_card_panel_MouseLeave(object sender, EventArgs e)
            => default_card_panel.FillColor = Color.FromArgb(34, 33, 42);

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

        public class VehicleEventArgs : EventArgs
        {
            public VehicleEventArgs(Vehicle vehicle) => Vehicle = vehicle;
            public Vehicle Vehicle { get; }
        }

        public class ReservationEventArgs : EventArgs
        {
            public ReservationEventArgs(Reservation reservation) => Reservation = reservation;
            public Reservation Reservation { get; }
        }
    }
}