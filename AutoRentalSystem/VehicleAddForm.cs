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
    public partial class VehicleAddForm : Form
    {
        public VehicleAddForm()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
        }

        private void btn_AddVehicleForm_Close_Click(object sender, EventArgs e) => Close();

        private void btn_AddVehicleForm_Close_MouseEnter(object sender, EventArgs e)
        {
            btn_AddVehicleForm_Close.FillColor = Color.Red;
        }

        private void btn_AddVehicleForm_Close_MouseLeave(object sender, EventArgs e)
        {
            btn_AddVehicleForm_Close.FillColor = Color.Transparent;
        }
    }
}
