using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace AutoRentalSystem
{
    public partial class ReserveVehicleForm : Form
    {
        private readonly Vehicle _vehicle;
        private readonly Reservation _editingReservation;

        // Criar reserva
        public ReserveVehicleForm(Vehicle vehicle)
        {
            InitializeComponent();
            _vehicle = vehicle ?? throw new ArgumentNullException(nameof(vehicle));

            SetupCommonUi();

            dateTimePicker_startDate.Value = AppClock.Today;
            dateTimePicker_endDate.Value = AppClock.Today.AddDays(1);

            UpdatePricePreview();
        }

        // Editar reserva
        public ReserveVehicleForm(Reservation reservation)
        {
            InitializeComponent();
            _editingReservation = reservation ?? throw new ArgumentNullException(nameof(reservation));
            _vehicle = reservation.Vehicle ?? throw new ArgumentException("Reservation has no vehicle.");

            SetupCommonUi();

            dateTimePicker_startDate.Value = reservation.StartDate.Date;
            dateTimePicker_endDate.Value = reservation.EndDate.Date;

            btn_reserveVehicle.Text = "Save";

            UpdatePricePreview();
        }

        private void SetupCommonUi()
        {
            textbox_licensePlate.Text = _vehicle.LicensePlate;
            textbox_licensePlate.ReadOnly = true;
            textbox_licensePlate.Enabled = false;

            textbox_totalPrice.ReadOnly = true;
            textbox_totalPrice.TabStop = false;
            textbox_totalPrice.Enabled = false;

            dateTimePicker_startDate.ValueChanged += (_, __) => UpdatePricePreview();
            dateTimePicker_endDate.ValueChanged += (_, __) => UpdatePricePreview();

            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
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

            decimal total = totalDays * _vehicle.DailyPrice;

            textbox_totalPrice.Text = total.ToString("C", new CultureInfo("pt-PT"));
        }

        private void btn_reserveVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                var start = dateTimePicker_startDate.Value.Date;
                var end = dateTimePicker_endDate.Value.Date;

                if (_editingReservation != null)
                {
                    // EDITAR
                    var updated = ReservationManager.UpdateReservation(
                        _editingReservation.Id,
                        start,
                        end,
                        _editingReservation.Status 
                    );

                    MessageBox.Show(
                        $"Reservation updated with success!\nTotal: {updated.TotalPrice:C}",
                        "Reservation updated",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    // CRIAR
                    var created = ReservationManager.CreateReservation(_vehicle, start, end);

                    MessageBox.Show(
                        $"Reservation created with success!\nTotal: {created.TotalPrice:C}",
                        "Reservation confirmed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        public void btn_close_Click(object sender, EventArgs e) => Close();

        public void btn_close_MouseEnter(object sender, EventArgs e) => btn_close.FillColor = Color.Red;

        public void btn_close_MouseLeave(object sender, EventArgs e) => btn_close.FillColor = Color.Transparent;
    }
}
