using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace AutoRentalSystem
{
    public partial class VehicleCards : UserControl
    {
        private static readonly string[] VehicleActionButtons =
        {
            "btn_reserve_vehicle",
            "btn_edit_vehicle",
            "btn_delete_vehicle"
        };

        private static readonly string[] ReservationActionButtons =
        {
            "btn_edit_reservation",
            "btn_delete_reservation"
        };

        private Vehicle _vehicle;
        private Reservation _reservation;
        private bool _isReservationCard;
        private CardMode _mode = CardMode.VehiclesPage;
        private Control _actionsControl;

        // Events for vehicles
        public event EventHandler<VehicleEventArgs> DeleteRequested;
        public event EventHandler<VehicleEventArgs> EditRequested;

        // Extra actions (VehiclesPage)
        public event EventHandler<VehicleEventArgs> ReserveRequested;

        // Events for reservations
        public event EventHandler<ReservationEventArgs> ReservationDeleteRequested;
        public event EventHandler<ReservationEventArgs> ReservationEditRequested;

        public event EventHandler CardClicked;

        public enum CardMode
        {
            VehiclesPage,
            ReservationsPage
        }

        public VehicleCards()
        {
            InitializeComponent();

            Cursor = Cursors.Hand;
            default_card_panel.Cursor = Cursors.Hand;

            WireCardClick(default_card_panel);
        }

        public VehicleCards(Vehicle vehicle) : this()
        {
            BindVehicle(vehicle);
        }

        private void WireCardClick(Control parent)
        {
            parent.Click -= default_card_panel_Click;
            parent.Click += default_card_panel_Click;

            foreach (Control c in parent.Controls)
            {
                // não queremos que o clique em botões abra detalhes
                if (IsActionButton(c))
                    continue;

                WireCardClick(c);
            }
        }

        public void SetMode(CardMode mode)
        {
            _mode = mode;

            var showVehicleButtons = mode == CardMode.VehiclesPage;
            SetVisibleIfExists("btn_reserve_vehicle", showVehicleButtons);
            SetVisibleIfExists("btn_edit_vehicle", showVehicleButtons);
            SetVisibleIfExists("btn_delete_vehicle", showVehicleButtons);
            SetVisibleIfExists("btn_edit_reservation", !showVehicleButtons);
            SetVisibleIfExists("btn_delete_reservation", !showVehicleButtons);
        }

        private void SetVisibleIfExists(string controlName, bool visible)
        {
            var c = FindControlDeep(this, controlName);
            if (c != null) c.Visible = visible;
        }

        private static bool IsActionButton(Control control)
        {
            if (control == null) return false;

            return VehicleActionButtons.Contains(control.Name)
                || ReservationActionButtons.Contains(control.Name);
        }

        private Control FindControlDeep(Control root, string name)
        {
            if (root == null) return null;
            if (root.Name == name) return root;

            foreach (Control child in root.Controls)
            {
                var found = FindControlDeep(child, name);
                if (found != null) return found;
            }

            return null;
        }

        private void EnsureActionsControl(CardMode mode)
        {
            if (panel_actions == null)
                return;

            var requiresVehicleActions = mode == CardMode.VehiclesPage;
            var currentVehicleActions = _actionsControl is UC_VehicleCards_VehiclesPage;
            var currentReservationActions = _actionsControl is UC_VehicleCards_ReservationPage;

            if ((requiresVehicleActions && currentVehicleActions)
                || (!requiresVehicleActions && currentReservationActions))
            {
                SetMode(mode);
                return;
            }

            panel_actions.Controls.Clear();
            _actionsControl?.Dispose();

            _actionsControl = requiresVehicleActions
                ? (Control)new UC_VehicleCards_VehiclesPage()
                : new UC_VehicleCards_ReservationPage();

            _actionsControl.Dock = DockStyle.Fill;
            panel_actions.Controls.Add(_actionsControl);

            WireActionButtons(_actionsControl);
            SetMode(mode);
        }

        private void WireActionButtons(Control root)
        {
            if (root == null) return;

            WireButton(root, "btn_reserve_vehicle", BtnReserve_Click, HandleReserveMouseEnter, HandleReserveMouseLeave);
            WireButton(root, "btn_delete_vehicle", btn_delete_vehicle_Click, HandleDeleteMouseEnter, HandleDeleteMouseLeave);
            WireButton(root, "btn_edit_vehicle", btn_editVehicle_Click, HandleEditMouseEnter, HandleEditMouseLeave);

            WireButton(root, "btn_delete_reservation", btn_delete_vehicle_Click, HandleDeleteMouseEnter, HandleDeleteMouseLeave);
            WireButton(root, "btn_edit_reservation", btn_editVehicle_Click, HandleEditMouseEnter, HandleEditMouseLeave);
        }

        private void WireButton(
            Control root,
            string name,
            EventHandler clickHandler,
            EventHandler mouseEnterHandler,
            EventHandler mouseLeaveHandler)
        {
            var button = FindControlDeep(root, name);
            if (button == null) return;

            button.Click -= clickHandler;
            button.Click += clickHandler;

            if (mouseEnterHandler != null)
            {
                button.MouseEnter -= mouseEnterHandler;
                button.MouseEnter += mouseEnterHandler;
            }

            if (mouseLeaveHandler != null)
            {
                button.MouseLeave -= mouseLeaveHandler;
                button.MouseLeave += mouseLeaveHandler;
            }
        }

        private void BtnReserve_Click(object sender, EventArgs e)
        {
            if (_vehicle == null) return;
            ReserveRequested?.Invoke(this, new VehicleEventArgs(_vehicle));
        }

        public void BindVehicle(Vehicle vehicle)
        {
            if (vehicle == null) return;

            _isReservationCard = false;
            _reservation = null;
            _vehicle = vehicle;

            EnsureActionsControl(CardMode.VehiclesPage);

            pictureBox_RentState.Image = GetRentStateIcon(vehicle.RentState);
            label1.Text = vehicle.LicensePlate;
            label2.Text = vehicle.VehicleType;
            label3.Text = vehicle.Maker;
            label4.Text = vehicle.Model;
            label5.Text = vehicle.Year.ToString();
            label6.Text = vehicle.DailyPrice.ToString("C", new CultureInfo("pt-PT"));
        }

        public void BindReservation(Reservation reservation)
        {
            if (reservation == null) return;

            _isReservationCard = true;
            _reservation = reservation;
            _vehicle = reservation.Vehicle;

            EnsureActionsControl(CardMode.ReservationsPage);

            label1.Text = _vehicle?.LicensePlate ?? "—";
            label2.Text = _vehicle?.GetType().Name ?? "—";
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

        private void default_card_panel_MouseEnter(object sender, EventArgs e)
        {
            default_card_panel.FillColor = Color.FromArgb(45, 45, 60);
        }

        private void default_card_panel_MouseLeave(object sender, EventArgs e)
        {
            default_card_panel.FillColor = Color.FromArgb(34, 33, 42);
        }

        private void HandleDeleteMouseEnter(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2Button button)
                button.FillColor = Color.Red;
        }

        private void HandleDeleteMouseLeave(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2Button button)
                button.FillColor = Color.Transparent;
        }

        private void HandleEditMouseEnter(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2Button button)
                button.FillColor = Color.Orange;
        }

        private void HandleEditMouseLeave(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2Button button)
                button.FillColor = Color.Transparent;
        }

        private void HandleReserveMouseEnter(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2Button button)
                button.FillColor = Color.Orange;
        }

        private void HandleReserveMouseLeave(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2Button button)
                button.FillColor = Color.Transparent;
        }

        private void btn_delete_vehicle_Click(object sender, EventArgs e)
        {
            if (_reservation != null)
            {
                ReservationDeleteRequested?.Invoke(this, new ReservationEventArgs(_reservation));
                return;
            }

            if (_vehicle != null)
                DeleteRequested?.Invoke(this, new VehicleEventArgs(_vehicle));
        }

        private void btn_editVehicle_Click(object sender, EventArgs e)
        {
            if (_reservation != null)
            {
                ReservationEditRequested?.Invoke(this, new ReservationEventArgs(_reservation));
                return;
            }

            if (_vehicle != null)
                EditRequested?.Invoke(this, new VehicleEventArgs(_vehicle));
        }

        private void default_card_panel_Click(object sender, EventArgs e)
        {
            // Se não houver veículo associado, não faz nada
            if (_vehicle == null)
                return;

            CardClicked?.Invoke(this, EventArgs.Empty);

            using (var details = new VehicleDetailsForm(_vehicle))
            {
                details.StartPosition = FormStartPosition.CenterParent;
                details.ShowDialog(this.FindForm());
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
