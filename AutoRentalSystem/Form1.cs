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
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
            title_label.Text = " ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btn_vehicles.FillColor = Color.FromArgb(50, 100, 201);
            btn_vehicles.FillColor2 = Color.FromArgb(144, 117, 203);
            title_label.Text = btn_vehicles.Text;

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btn_reservations.FillColor = Color.FromArgb(50, 100, 201);
            btn_reservations.FillColor2 = Color.FromArgb(144, 117, 203);
            title_label.Text = btn_reservations.Text;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btn_maintenence.FillColor = Color.FromArgb(50, 100, 201);
            btn_maintenence.FillColor2 = Color.FromArgb(144, 117, 203);
            title_label.Text = btn_maintenence.Text;
        }

        private void ButtonOff()
        {
            btn_vehicles.FillColor = Color.Transparent;
            btn_vehicles.FillColor2 = Color.Transparent;

            btn_reservations.FillColor = Color.Transparent;
            btn_reservations.FillColor2 = Color.Transparent;

            btn_maintenence.FillColor = Color.Transparent;
            btn_maintenence.FillColor2 = Color.Transparent;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
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

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
