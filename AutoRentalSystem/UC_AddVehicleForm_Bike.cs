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
    public partial class UC_AddVehicleForm_Bike : UserControl
    {
        public event EventHandler AddVehicleRequested;
        public UC_AddVehicleForm_Bike()
        {
            InitializeComponent();
            btn_UC_AddVehicleForm_Bike_AddVehicle.Click += HandleAddVehicleClick;
        }
        public string CcText => textbox_UC_Bike_CC.Text;

        private void HandleAddVehicleClick(object sender, EventArgs e)
        {
            AddVehicleRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
