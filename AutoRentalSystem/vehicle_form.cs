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
    public partial class vehicle_form : Form
    {
        public vehicle_form()
        {
            InitializeComponent();
            title_label.Text = "Vehicles";
        }

        private void btn_vehicles_Click(object sender, EventArgs e)
        {
            vehicle_form vehicleForm = new vehicle_form();
            vehicleForm.Show();
            this.Hide();
        }

        private void btn_reservations_Click(object sender, EventArgs e)
        {
            title_label.Text = btn_reservations.Text;
        }

        private void btn_maintenance_Click(object sender, EventArgs e)
        {
            title_label.Text = btn_maintenance.Text;
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_minimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_add_vehicle_Click(object sender, EventArgs e)
        {
            VehicleCards card = new VehicleCards();
            flow_panel.Controls.Add(card);
        }

        private void btn_vehicles_MouseEnter(object sender, EventArgs e)
        {
            btn_vehicles.FillColor = Color.Orange;
            btn_vehicles.FillColor2 = Color.Orange;
        }

        private void btn_vehicles_MouseLeave(object sender, EventArgs e)
        {
            btn_vehicles.FillColor = Color.Transparent;
            btn_vehicles.FillColor2 = Color.Transparent;
        }

        private void btn_reservations_MouseEnter(object sender, EventArgs e)
        {
            btn_reservations.FillColor = Color.Orange;
            btn_reservations.FillColor2 = Color.Orange;
        }

        private void btn_reservations_MouseLeave(object sender, EventArgs e)
        {
            btn_reservations.FillColor = Color.Transparent;
            btn_reservations.FillColor2 = Color.Transparent;
        }

        private void btn_maintenance_MouseEnter(object sender, EventArgs e)
        {
            btn_maintenance.FillColor = Color.Orange;
            btn_maintenance.FillColor2 = Color.Orange;
        }

        private void btn_maintenance_MouseLeave(object sender, EventArgs e)
        {
            btn_maintenance.FillColor = Color.Transparent;
            btn_maintenance.FillColor2 = Color.Transparent;
        }
        private void label_description_Click(object sender, EventArgs e) { }

    }
}
