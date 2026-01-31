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
    public partial class UC_VehicleDetails_Truck : UserControl
    {
        public UC_VehicleDetails_Truck()
        {
            InitializeComponent();
        }
        internal void LoadData(Truck truck)
        {
            if (truck == null) return;

            label_height_info.Text = truck.Height.ToString();
            label_maxWeight_info.Text = truck.MaxWeight.ToString();
        }
    }
}
