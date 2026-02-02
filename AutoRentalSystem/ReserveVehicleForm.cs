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
    public partial class ReserveVehicleForm : Form
    {
        private readonly Vehicle _vehicle;
        private readonly Reservation _reservation; // null = create, not null = edit

        public ReserveVehicleForm(Vehicle vehicle)
        {
            InitializeComponent();
            _vehicle = vehicle ?? throw new ArgumentNullException(nameof(vehicle));
            _reservation = null;
            SetupForm(vehicle.LicensePlate, AppClock.Today, AppClock.Today.AddDays(1));
        }

        public ReserveVehicleForm(Reservation reservation)
        {
            InitializeComponent();
            _reservation = reservation ?? throw new ArgumentNullException(nameof(reservation));
            _vehicle = reservation.Vehicle;
            if (_vehicle == null)
                throw new ArgumentException("Reservation must have a vehicle.");
            SetupForm(_vehicle.LicensePlate, reservation.StartDate.Date, reservation.EndDate.Date);
        }

        private void SetupForm(string licensePlate, DateTime startDate, DateTime endDate)
        {
            textbox_licensePlate.Text = licensePlate ?? string.Empty;
            textbox_licensePlate.ReadOnly = true;
            textbox_licensePlate.Enabled = false;

            textbox_totalPrice.ReadOnly = true;
            textbox_totalPrice.TabStop = false;
            textbox_totalPrice.Enabled = false;

            dateTimePicker_startDate.Value = startDate;
            dateTimePicker_endDate.Value = endDate;

            dateTimePicker_startDate.ValueChanged += (_, __) => UpdatePricePreview();
            dateTimePicker_endDate.ValueChanged += (_, __) => UpdatePricePreview();

            if (_reservation != null)
            {
                label_title.Text = "Edit Reservation";
                btn_reserveVehicle.Text = "Save";
            }

            UpdatePricePreview();

            this.BackColor = Color.FromArgb(34, 33, 42);
            this.TransparencyKey = Color.FromArgb(34, 33, 42);
        }

        private void UpdatePricePreview()
        {
            var start = dateTimePicker_startDate.Value.Date;
            var end = dateTimePicker_endDate.Value.Date;

            if (end < start)
            {
                textbox_totalPrice.Text = "—";
                return;
            }

            int totalDays = (int)Math.Ceiling((end - start).TotalDays);
            if (totalDays < 1) totalDays = 1;

            decimal dailyPrice = _vehicle?.DailyPrice > 0 ? _vehicle.DailyPrice : ReservationManager.DefaultDailyPrice;
            decimal total = totalDays * dailyPrice;

            textbox_totalPrice.Text = total.ToString("C", new CultureInfo("pt-PT"));
        }

        private void Actions_ReserveClicked(object sender, EventArgs e)
        {
            if (_vehicle == null)
                return;

            using (var form = new ReserveVehicleForm(_vehicle))
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this.FindForm());
            }
        }

        private void btn_reserveVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                var startDate = dateTimePicker_startDate.Value.Date;
                var endDate = dateTimePicker_endDate.Value.Date;

                if (_reservation != null)
                {
                    var status = ComputeStatus(startDate, endDate);
                    ReservationManager.UpdateReservation(_reservation.Id, startDate, endDate, status);
                    MessageBox.Show(
                        "Reservation updated with success!",
                        "Reservation updated",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    var reservation = ReservationManager.CreateReservation(_vehicle, startDate, endDate);
                    MessageBox.Show(
                        $"Reservation created with success!\nTotal: {reservation.TotalPrice:C}",
                        "Reservation confirmed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    _reservation != null ? "Error updating reservation" : "Error creating reservation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private static ReservationStatus ComputeStatus(DateTime startDate, DateTime endDate)
        {
            var today = AppClock.Today.Date;
            if (endDate.Date <= today) return ReservationStatus.Completed;
            if (startDate.Date <= today) return ReservationStatus.Active;
            return ReservationStatus.Reserved;
        }

        public void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btn_close_MouseEnter(object sender, EventArgs e)
        {
            btn_close.FillColor = Color.Red;
        }

        public void btn_close_MouseLeave(object sender, EventArgs e)
        {
            btn_close.FillColor = Color.Transparent;
        }
    }
}