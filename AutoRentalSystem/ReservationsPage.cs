using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoRentalSystem
{
    public partial class ReservationsPage_Background : UserControl
    {
        public ReservationsPage_Background()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void ReservationsPage_Load(object sender, EventArgs e)
        {
            ReservationManager.ReservationsChanged += OnReservationsChanged;
            RenderReservations();
        }

        private void OnReservationsChanged()
        {
            if (IsDisposed) return;

            if (InvokeRequired)
            {
                BeginInvoke(new Action(RenderReservations));
                return;
            }

            RenderReservations();
        }

        private void RenderReservations()
        {
            flowLayoutPanel_reservations.Controls.Clear();

            foreach (var r in ReservationManager.Reservations)
            {
                var card = new VehicleCards();
                card.BindReservation(r);
                flowLayoutPanel_reservations.Controls.Add(card);
            }
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            ReservationManager.ReservationsChanged -= OnReservationsChanged;
            base.OnHandleDestroyed(e);
        }
    }
}