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
    public partial class UC_VehicleDetails_Car : UserControl
    {
        public UC_VehicleDetails_Car()
        {
            InitializeComponent();
        }
        internal void LoadData(Car car)
        {
            if (car == null) return;

            label_numberDoors_info.Text = car.NumberDoors.ToString();
        }
    }
}
