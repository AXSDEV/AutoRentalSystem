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
    public partial class UC_AddVehicleForm_Car_Background : UserControl
    {
        public event EventHandler AddVehicleRequested;
        public UC_AddVehicleForm_Car_Background()
        {
            InitializeComponent();
            btn_UC_AddVehicleForm_Car_AddVehicle.Click += HandleAddVehicleClick;
        }
        public string NumberOfDoorsText => textbox_UC_Car_NumberOfDoors.Text;
        private void btn_UC_AddVehicleForm_Car_AddVehicle_MouseEnter(object sender, EventArgs e)
        {
            btn_UC_AddVehicleForm_Car_AddVehicle.FillColor = Color.Orange;
        }

        private void btn_UC_AddVehicleForm_Car_AddVehicle_MouseLeave(object sender, EventArgs e)
        {
            btn_UC_AddVehicleForm_Car_AddVehicle.FillColor = Color.Transparent;
        }
        private void HandleAddVehicleClick(object sender, EventArgs e)
        {
            AddVehicleRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
