using System;
using System.Windows.Forms;

namespace AutoRentalSystem
{
    public partial class UC_VehicleCards_MaintenancePage : UserControl
    {
        public event EventHandler EditClicked;
        public event EventHandler DeleteClicked;
        public event EventHandler AlterStateClicked;

        public UC_VehicleCards_MaintenancePage()
        {
            InitializeComponent();

            btn_alterState.Click += (_, __) => AlterStateClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btn_alterState_MouseEnter(object sender, EventArgs e)
        {
            btn_alterState.FillColor = System.Drawing.Color.Yellow;
        }

        private void btn_alterState_MouseLeave(object sender, EventArgs e)
        {
            btn_alterState.FillColor = System.Drawing.Color.Transparent;
        }

    }
}
