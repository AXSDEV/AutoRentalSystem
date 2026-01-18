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
    public partial class VehiclesPage : UserControl
    {
        public VehiclesPage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void btn_add_vehicle_Click(object sender, EventArgs e)
        {
            VehicleCards card = new VehicleCards();
            flow_panel.Controls.Add(card);
        }
        private void VehiclesPage_Load(object sender, EventArgs e)
        {
        }
    }

}
