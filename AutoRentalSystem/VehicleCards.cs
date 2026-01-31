using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace AutoRentalSystem
{
    public partial class VehicleCards : UserControl
    {
        private Vehicle _vehicle;
        private Reservation _reservation;
        private bool _isReservationCard;
        private CardMode _mode = CardMode.VehiclesPage;

        // Events for vehicles
        public event EventHandler<VehicleEventArgs> DeleteRequested;
        public event EventHandler<VehicleEventArgs> EditRequested;

        // Extra actions (VehiclesPage)
        public event EventHandler<VehicleEventArgs> ReserveRequested;
        public event EventHandler<VehicleEventArgs> AlterStateRequested;

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

            // Make the card clickable
            this.Cursor = Cursors.Hand;
            default_card_panel.Cursor = Cursors.Hand;

            WireCardClick(default_card_panel);
            WireExtraButtons();
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
                if (c == btn_delete_vehicle || c == btn_editVehicle ||
                    c.Name == "btn_reserveVehicle" || c.Name == "btn_alterState")
                    continue;

                WireCardClick(c);
            }
        }

        public void SetMode(CardMode mode)
        {
            _mode = mode;

            // Botões "base" existem sempre no Designer
            // (em reservas, normalmente queres esconder "editar").
            btn_editVehicle.Visible = (mode == CardMode.VehiclesPage);

            // Botões extra podem não existir neste card (dependendo do UC/Designer).
            SetVisibleIfExists("btn_reserveVehicle", mode == CardMode.VehiclesPage);
            SetVisibleIfExists("btn_alterState", mode == CardMode.VehiclesPage);
        }

        private void SetVisibleIfExists(string controlName, bool visible)
        {
            var c = FindControlDeep(this, controlName);
            if (c != null) c.Visible = visible;
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

        private void WireExtraButtons()
        {
            var btnReserve = FindControlDeep(this, "btn_reserveVehicle");
            if (btnReserve != null)
            {
                btnReserve.Click -= BtnReserve_Click;
                btnReserve.Click += BtnReserve_Click;
            }

            var btnAlterState = FindControlDeep(this, "btn_alterState");
            if (btnAlterState != null)
            {
                btnAlterState.Click -= BtnAlterState_Click;
                btnAlterState.Click += BtnAlterState_Click;
            }
        }

        private void BtnReserve_Click(object sender, EventArgs e)
        {
            if (_vehicle == null) return;
            ReserveRequested?.Invoke(this, new VehicleEventArgs(_vehicle));
        }

        private void BtnAlterState_Click(object sender, EventArgs e)
        {
            if (_vehicle == null) return;
            AlterStateRequested?.Invoke(this, new VehicleEventArgs(_vehicle));
        }

        public void BindVehicle(Vehicle vehicle)
        {
            if (vehicle == null) return;

            _isReservationCard = false;
            _reservation = null;
            _vehicle = vehicle;

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

            // Ícone: podes manter o estado do veículo, se existir
            pictureBox_RentState.Image = _vehicle != null ? GetRentStateIcon(_vehicle.RentState) : null;

            label1.Text = _vehicle?.LicensePlate ?? "—";
            label2.Text = _vehicle?.GetType().Name ?? "—";
            label3.Text = reservation.StartDate.ToString("yyyy-MM-dd");
            label4.Text = reservation.EndDate.ToString("yyyy-MM-dd");
            label5.Text = reservation.TotalPrice.ToString("C", new CultureInfo("pt-PT"));
            label6.Text = reservation.IsCompleted ? "Concluída" : "Ativa";

            pictureBox_RentState.Image = reservation.IsCompleted
                ? Properties.Resources.state_available
                : Properties.Resources.state_maintenance;
        }

        private void Bind(Image icon, string c1, string c2, string c3, string c4, string c5, string c6)
        {
            pictureBox_RentState.Image = icon;

            label1.Text = c1;
            label2.Text = c2;
            label3.Text = c3;
            label4.Text = c4;
            label5.Text = c5;
            label6.Text = c6;
        }

        private Image GetRentStateIcon(string rentState)
        {
            var state = (rentState ?? "").Trim().ToLowerInvariant();

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

        private void btn_delete_vehicle_MouseEnter(object sender, EventArgs e)
        {
            btn_delete_vehicle.FillColor = Color.Red;
        }

        private void btn_delete_vehicle_MouseLeave(object sender, EventArgs e)
        {
            btn_delete_vehicle.FillColor = Color.Transparent;
        }

        private void btn_editVehicle_MouseEnter(object sender, EventArgs e)
        {
            btn_editVehicle.FillColor = Color.Orange;
        }

        private void btn_editVehicle_MouseLeave(object sender, EventArgs e)
        {
            btn_editVehicle.FillColor = Color.Transparent;
        }

        private void btn_delete_vehicle_Click(object sender, EventArgs e)
        {
            if (_reservation != null)
            {
                ReservationDeleteRequested?.Invoke(this, new ReservationEventArgs(_reservation));
                return;
            }

            if (_vehicle != null)
            {
                DeleteRequested?.Invoke(this, new VehicleEventArgs(_vehicle));
            }
        }

        private void btn_editVehicle_Click(object sender, EventArgs e)
        {
            if (_reservation != null)
            {
                ReservationEditRequested?.Invoke(this, new ReservationEventArgs(_reservation));
                return;
            }

            if (_vehicle != null)
            {
                EditRequested?.Invoke(this, new VehicleEventArgs(_vehicle));
            }
        }

        private void default_card_panel_Click(object sender, EventArgs e)
        {
            // Em cards de reservas, não queremos abrir detalhes do veículo por engano.
            if (_isReservationCard) return;

            if (_vehicle == null) return;

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
