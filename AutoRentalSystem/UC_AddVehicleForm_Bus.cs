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

        public string MaxPassengerText
        {
            get => textbox_UC_Bus_MaxPassenger.Text;
            set => textbox_UC_Bus_MaxPassenger.Text = value ?? string.Empty;
        }

        public string AxelNumberText
        {
            get => textbox_UC_Bus_AxelNumber.Text;
            set => textbox_UC_Bus_AxelNumber.Text = value ?? string.Empty;
        }

        private void HandleAddVehicleClick(object sender, EventArgs e)
        {
            AddVehicleRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
