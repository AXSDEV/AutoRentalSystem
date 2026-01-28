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
    public partial class UC_AddVehicleForm_Truck : UserControl
    {
        public event EventHandler AddVehicleRequested;

        public UC_AddVehicleForm_Truck()
        {
            InitializeComponent();
            btn_UC_AddVehicleForm_Truck_AddVehicle.Click += HandleAddVehicleClick;
        }

        public string MaxWeightText => textbox_UC_TruckMaxWeight.Text;

        public string HeightText => textbox_UC_Truck_Height.Text;

        private void HandleAddVehicleClick(object sender, EventArgs e)
        {
            AddVehicleRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
