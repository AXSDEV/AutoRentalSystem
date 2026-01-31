using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRentalSystem
{
    public partial class UC_VehicleCards_ReservationPage : UserControl
    {
        public event EventHandler EditClicked;
        public event EventHandler DeleteClicked;

        public UC_VehicleCards_ReservationPage()
        {
            InitializeComponent();

            btn_edit_reservation.Click += (_, __) => EditClicked?.Invoke(this, EventArgs.Empty);
            btn_delete_reservation.Click += (_, __) => DeleteClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btn_edit_reservation_Click(object sender, EventArgs e)
            => EditClicked?.Invoke(this, EventArgs.Empty);

        private void btn_delete_reservation_Click(object sender, EventArgs e)
            => DeleteClicked?.Invoke(this, EventArgs.Empty);

        private void btn_delete_reservation_MouseEnter(object sender, EventArgs e)
        {
            btn_delete_reservation.FillColor = Color.Red;
        }

        private void btn_delete_reservation_MouseLeave(object sender, EventArgs e)
        {
            btn_delete_reservation.FillColor = Color.Transparent;
        }

        private void btn_edit_reservation_MouseEnter(object sender, EventArgs e)
        {
            btn_edit_reservation.FillColor = Color.Orange;
        }

        private void btn_edit_reservation_MouseLeave(object sender, EventArgs e)
        {
            btn_edit_reservation.FillColor = Color.Transparent;
        }
    }
}
