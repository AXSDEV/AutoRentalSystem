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
        public VehicleCards()
        {
            InitializeComponent();
        }
        public VehicleCards(Vehicle vehicle) : this()
        {
            if (vehicle == null)
            {
                return;
            }
            pictureBox_RentState.Image = GetRentStateIcon(vehicle.RentState);
            label1.Text = vehicle.LicensePlate;
            label2.Text = vehicle.VehicleType;
            label3.Text = vehicle.Maker;
            label4.Text = vehicle.Model;
            label5.Text = vehicle.Year.ToString();
            label6.Text = vehicle.DailyPrice.ToString("C", new CultureInfo("pt-PT"));
        }

        private Image GetRentStateIcon(string rentState)
        {
            string state = rentState.Trim().ToLowerInvariant();

            switch (state)
            {
                case "available":
                    return Properties.Resources.state_available;

                case "reserved":
                    return Properties.Resources.state_reserved;

                case "rented":
                    return Properties.Resources.state_rented;

                case "maintenance":
                    return Properties.Resources.state_maintenance;
                default:
                    return null;
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

        private void btn_delete_vehicle_Click(object sender, EventArgs e)
        {

        }

        private void default_card_panel_Click(object sender, EventArgs e)
        {
           
        }
    }

}
