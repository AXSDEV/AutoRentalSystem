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
    public partial class UC_AddVehicleForm_Bus : UserControl
    {
        public event EventHandler AddVehicleRequested;
        public UC_AddVehicleForm_Bus()
        {
            InitializeComponent();
            btn_UC_AddVehicleForm_Bus_AddVehicle.Click += HandleAddVehicleClick;
        }

        public string MaxPassengerText => textbox_UC_Bus_MaxPassenger.Text;

        public string AxelNumberText => textbox_UC_Bus_AxelNumber.Text;

        private void HandleAddVehicleClick(object sender, EventArgs e)
        {
            AddVehicleRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
