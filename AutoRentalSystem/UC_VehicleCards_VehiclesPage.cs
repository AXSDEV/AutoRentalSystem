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
    public partial class UC_VehicleCards_VehiclesPage : UserControl
    {
        public event EventHandler ReserveClicked;
        public event EventHandler EditClicked;
        public event EventHandler DeleteClicked;
        public event EventHandler AlterStateClicked;


        public UC_VehicleCards_VehiclesPage()
        {
            InitializeComponent();

            btn_reserve_vehicle.Click += btn_reserve_vehicle_Click;
            btn_edit_vehicle.Click += (_, __) => EditClicked?.Invoke(this, EventArgs.Empty);
            btn_delete_vehicle.Click += (_, __) => DeleteClicked?.Invoke(this, EventArgs.Empty);
            btn_alterState.Click += btn_alterState_Click;
        }

        private void btn_reserve_vehicle_Click(object sender, EventArgs e)
        {
            ReserveClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btn_edit_vehicle_Click(object sender, EventArgs e)
            => EditClicked?.Invoke(this, EventArgs.Empty);

        private void btn_delete_vehicle_Click(object sender, EventArgs e)
            => DeleteClicked?.Invoke(this, EventArgs.Empty);

        private void btn_alterState_Click(object sender, EventArgs e)
            => AlterStateClicked?.Invoke(this, EventArgs.Empty);

        private void btn_reserve_vehicle_MouseEnter(object sender, EventArgs e)
        {
            btn_reserve_vehicle.FillColor = Color.Green;
        }

        private void btn_reserve_vehicle_MouseLeave(object sender, EventArgs e)
        {
            btn_reserve_vehicle.FillColor = Color.Transparent;
        }

        private void btn_edit_vehicle_MouseEnter(object sender, EventArgs e)
        {
            btn_edit_vehicle.FillColor = Color.Orange;
        }

        private void btn_edit_vehicle_MouseLeave(object sender, EventArgs e)
        {
            btn_edit_vehicle.FillColor = Color.Transparent;
        }

        private void btn_delete_vehicle_MouseEnter(object sender, EventArgs e)
        {
            btn_delete_vehicle.FillColor = Color.Red;
        }

        private void btn_delete_vehicle_MouseLeave(object sender, EventArgs e)
        {
            btn_delete_vehicle.FillColor = Color.Transparent;
        }

        private void btn_alterState_MouseEnter(object sender, EventArgs e)
        {
            btn_alterState.FillColor = Color.Yellow;
        }

        private void btn_alterState_MouseLeave(object sender, EventArgs e)
        {
            btn_alterState.FillColor = Color.Transparent;
        }
    }
}
