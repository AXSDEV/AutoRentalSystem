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
    public partial class UC_VehicleDetails_Bus : UserControl
    {
        public UC_VehicleDetails_Bus()
        {
            InitializeComponent();
        }
        internal void LoadData(Bus bus)
        {
            if (bus == null) return;

            label_axelNumber_info.Text = bus.AxelNumber.ToString();
            label_maxPassenger_info.Text = bus.MaxPax.ToString();
        }
    }
}
