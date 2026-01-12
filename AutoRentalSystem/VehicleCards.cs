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
    public partial class VehicleCards : UserControl
    {
        public VehicleCards()
        {
            InitializeComponent();
        }

        private void default_card_panel_MouseEnter(object sender, EventArgs e)
        {
            default_card_panel.FillColor = Color.Orange;
        }

        private void default_card_panel_MouseLeave(object sender, EventArgs e)
        {
            default_card_panel.FillColor = Color.FromArgb(34,33,42);
        }

        private void btn_delete_vehicle_MouseEnter(object sender, EventArgs e)
        {
            btn_delete_vehicle.FillColor = Color.Red;
        }

        private void btn_delete_vehicle_MouseLeave(object sender, EventArgs e)
        {
            btn_delete_vehicle.FillColor = Color.Transparent;
        }
    }
}
