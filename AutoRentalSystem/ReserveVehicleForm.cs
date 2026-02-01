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
        public ReserveVehicleForm(Vehicle vehicle)
        {
            InitializeComponent();

            _vehicle = vehicle;

            textbox_licensePlate.Text = vehicle.LicensePlate;
            textbox_licensePlate.ReadOnly = true;
            textbox_licensePlate.Enabled = false;


            textbox_totalPrice.ReadOnly = true;
            textbox_totalPrice.TabStop = false;
            textbox_totalPrice.Enabled = false;


            dateTimePicker_startDate.ValueChanged += (_, __) => UpdatePricePreview();
            dateTimePicker_endDate.ValueChanged += (_, __) => UpdatePricePreview();

            UpdatePricePreview();

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

            textbox_totalPrice.Text = total.ToString(
                "C",
                new CultureInfo("pt-PT")
            );
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
                var reservation = ReservationManager.CreateReservation(
                    _vehicle,
                    dateTimePicker_startDate.Value.Date,
                    dateTimePicker_endDate.Value.Date
                );

                MessageBox.Show(
                    $"Reservation created with success!\nTotal: {reservation.TotalPrice:C}",
                    "Reservation confirmed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error creating reservation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
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