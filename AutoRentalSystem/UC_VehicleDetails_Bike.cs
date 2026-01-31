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
    public partial class UC_VehicleDetails_Bike : UserControl
    {
        public UC_VehicleDetails_Bike()
        {
            InitializeComponent();
        }
        internal void LoadData(Motorcycle bike)
        {
            if (bike == null) return;

            label_cc_info.Text = bike.Cc.ToString();
        }
    }
}
