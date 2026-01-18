using Guna.UI2.WinForms;
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
    public partial class form_home : Form
    {
        private readonly Dictionary<Type, UserControl> _pages = new Dictionary<Type, UserControl>();

        public form_home()
        {
            InitializeComponent();

            title_label.Text = "";
            SetActiveButton(btn_vehicles);
            ShowPage<VehiclesPage>("Vehicles");
        }
        
        private void ShowPage<T>(string title) where T : UserControl, new()
        {
            title_label.Text = title;

            foreach (Control c in panelContent.Controls)
                c.Visible = false;

            if (!_pages.TryGetValue(typeof(T), out var page))
            {
                page = new T { Dock = DockStyle.Fill };
                _pages[typeof(T)] = page;
                panelContent.Controls.Add(page);
            }

            page.Visible = true;
            page.BringToFront();
        }

        private void SetActiveButton(Guna.UI2.WinForms.Guna2GradientButton active)
        {
            foreach (Control c in guna2Panel1.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2GradientButton b)
                {
                    b.FillColor = Color.Transparent;
                    b.FillColor2 = Color.Transparent;
                }
            }

            active.FillColor = Color.Orange;
            active.FillColor2 = Color.Orange;
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_vehicles);
            ShowPage<VehiclesPage>("Vehicles");
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_reservations);
            ShowPage<ReservationsPage>("Reservations");
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            SetActiveButton(btn_maintenance);
            ShowPage<MaintenancePage>("Maintenance");
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

        private void label1_Click(object sender, EventArgs e) { }

        private void btn_close_Click(object sender, EventArgs e) => Application.Exit();

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            WindowState = (WindowState == FormWindowState.Maximized)
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }

}
