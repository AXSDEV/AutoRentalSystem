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
    public partial class VehicleDetailsForm : Form
    {
        private Vehicle _vehicle;

        public VehicleDetailsForm(Vehicle vehicle)
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
            _vehicle = vehicle;
            LoadData();
        }

        private void LoadData()
        {
            if (_vehicle == null) return;
        }

        private void btn_close_MouseEnter(object sender, EventArgs e)
        {
            btn_close.FillColor = Color.Red;
        }

        private void btn_close_MouseLeave(object sender, EventArgs e)
        {
            btn_close.FillColor = Color.Transparent;
        }

        private void btn_close_Click(object sender, EventArgs e) => Close();
    }
}
