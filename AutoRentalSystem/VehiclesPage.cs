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
    public partial class VehiclesPage : UserControl
    {
        public VehiclesPage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            this.AutoScroll = false;

            foreach (Control c in this.Controls)
            {
                Console.WriteLine($"{c.Name} - AutoScroll: {c is ScrollableControl sc && sc.AutoScroll}");
            }
        }

        private void btn_add_vehicle_Click(object sender, EventArgs e)
        {
            VehicleCards card = new VehicleCards();
            flowpanel_list.Controls.Add(card);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 100; i++)
            {
                VehicleCards card = new VehicleCards();
                flowpanel_list.Controls.Add(card);
            }

        }
        private bool _samplesLoaded;
        private void VehiclesPage_Load(object sender, EventArgs e)
        {
            if (_samplesLoaded)
            {
                return;
            }

            AddSampleVehicles();
            _samplesLoaded = true;
        }

        private void AddSampleVehicles()
        {
            var samples = new List<Vehicle>
            {
                new Car("Available", "Toyota", "Corolla", 2021, "AA-12-BB", "Yes", 5, "Automatic", "Gasoline", 45.0m),
                new Car("Available", "Volkswagen", "Golf", 2020, "CC-34-DD", "Yes", 5, "Manual", "Diesel", 42.5m),
                new Car("Unavailable", "BMW", "320i", 2022, "EE-56-FF", "No", 5, "Automatic", "Gasoline", 75.0m)
            };

            foreach (var vehicle in samples)
            {
                flowpanel_list.Controls.Add(new VehicleCards(vehicle));
            }
        }
    }
}
