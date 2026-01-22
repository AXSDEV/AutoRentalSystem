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
    public partial class VehicleAddForm : Form
    {
        private List<Guna2Button> _vehicleButtons;
        private UC_AddVehicleForm_Car_Background ucCar;
        private UC_AddVehicleForm_Bike ucBike;
        private UC_AddVehicleForm_Bus ucBus;
        private UC_AddVehicleForm_Truck ucTruck;

        public VehicleAddForm()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            ucCar = new UC_AddVehicleForm_Car_Background { Dock = DockStyle.Fill, Visible = false };
            ucBike = new UC_AddVehicleForm_Bike { Dock = DockStyle.Fill, Visible = false };
            ucBus = new UC_AddVehicleForm_Bus { Dock = DockStyle.Fill, Visible = false };
            ucTruck = new UC_AddVehicleForm_Truck { Dock = DockStyle.Fill, Visible = false };

            panel_AddVehicleForm_Content.Controls.Add(ucCar);
            panel_AddVehicleForm_Content.Controls.Add(ucBike);
            panel_AddVehicleForm_Content.Controls.Add(ucBus);
            panel_AddVehicleForm_Content.Controls.Add(ucTruck);
        }

        private void btn_AddVehicleForm_Close_Click(object sender, EventArgs e) => Close();

        private void btn_AddVehicleForm_Close_MouseEnter(object sender, EventArgs e)
        {
            btn_AddVehicleForm_Close.FillColor = Color.Red;
        }

        private void btn_AddVehicleForm_Close_MouseLeave(object sender, EventArgs e)
        {
            btn_AddVehicleForm_Close.FillColor = Color.Transparent;
        }

        private void ShowVehiclePanel(Control panelToShow)
        {
            foreach (Control c in panel_AddVehicleForm_Content.Controls)
                c.Visible = false;

            panelToShow.Visible = true;
            panelToShow.BringToFront();
        }

        private void btn_AddVehicleForm_Car_Click(object sender, EventArgs e)
        {
            ShowVehiclePanel(ucCar);
        }

        private void btn_AddVehicleForm_Bike_Click(object sender, EventArgs e)
        {
            ShowVehiclePanel(ucBike);
        }

        private void btn_AddVehicleForm_Bus_Click(object sender, EventArgs e)
        {
            ShowVehiclePanel(ucBus);
        }

        private void btn_AddVehicleForm_Truck_Click(object sender, EventArgs e)
        {
            ShowVehiclePanel(ucTruck);
        }
    }
}
