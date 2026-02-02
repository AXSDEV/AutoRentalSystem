using Guna.UI2.WinForms;
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
    public partial class form_home : Form
    {
        private readonly Dictionary<Type, UserControl> _pages = new Dictionary<Type, UserControl>();
        public form_home()
        {
            InitializeComponent();

            DateTimePicker_changeDay.Value = AppClock.Today;
            DateTimePicker_changeDay.ValueChanged += DateTimePicker_changeDay_ValueChanged;
            AppClock.DateChanged += OnAppDateChanged;
            ReservationManager.ReservationsFilePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "data", "reservations.csv");

            var dir = Path.GetDirectoryName(ReservationManager.ReservationsFilePath);
            if (!string.IsNullOrEmpty(dir))
                Directory.CreateDirectory(dir);

            var vehiclesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "vehicles.csv");
            if (File.Exists(vehiclesPath) && File.Exists(ReservationManager.ReservationsFilePath))
            {
                var vehicles = CsvExportService.ImportVehicles(vehiclesPath);
                ReservationManager.LoadReservationsFromFile(vehicles, ReservationManager.ReservationsFilePath);
            }
            ReservationManager.UpdateReservationStatuses(AppClock.Today);
            ShowPage<DashboardPage>("Dashboard");

        }

        private void ShowPage<T>(string title) where T : UserControl, new()
        {
            title_label.Text = title;

            foreach (Control c in panel_content.Controls)
                c.Visible = false;

            if (!_pages.TryGetValue(typeof(T), out var page))
            {
                page = new T { Dock = DockStyle.Fill };
                _pages[typeof(T)] = page;
                panel_content.Controls.Add(page);
            }

            page.Visible = true;
            page.BringToFront();
        }

        private void btn_vehicles_Click(object sender, EventArgs e)
        {
            ShowPage<VehiclesPage>("Vehicles");

        }

        private void btn_reservations_Click(object sender, EventArgs e)
        {
            ShowPage<ReservationsPage_Background>("Reservations");
        }

        private void btn_maintenance_Click(object sender, EventArgs e)
        {
            ShowPage<MaintenancePage>("Maintenance");
        }
        private void btn_vehicles_MouseEnter(object sender, EventArgs e)
        {
            btn_vehicles.FillColor = Color.Orange;
            btn_vehicles.FillColor2 = Color.Orange;
        }
        private void btn_vehicles_MouseLeave(object sender, EventArgs e)
        {
            btn_vehicles.FillColor = Color.Transparent;
            btn_vehicles.FillColor2 = Color.Transparent;
        }

        private void btn_reservations_MouseEnter(object sender, EventArgs e)
        {
            btn_reservations.FillColor = Color.Orange;
            btn_reservations.FillColor2 = Color.Orange;
        }
        private void btn_reservations_MouseLeave(object sender, EventArgs e)
        {
            btn_reservations.FillColor = Color.Transparent;
            btn_reservations.FillColor2 = Color.Transparent;
        }

        private void btn_maintenance_MouseEnter(object sender, EventArgs e)
        {
            btn_maintenance.FillColor = Color.Orange;
            btn_maintenance.FillColor2 = Color.Orange;
        }
        private void btn_maintenance_MouseLeave(object sender, EventArgs e)
        {
            btn_maintenance.FillColor = Color.Transparent;
            btn_maintenance.FillColor2 = Color.Transparent;
        }

        private void btn_close_Click(object sender, EventArgs e) => Application.Exit();

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            WindowState = (WindowState == FormWindowState.Maximized)
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_addvehicle_MouseEnter(object sender, EventArgs e)
        {
            btn_addvehicle.FillColor = Color.Orange;
            btn_addvehicle.FillColor2 = Color.Orange;
        }

        private void btn_addvehicle_MouseLeave(object sender, EventArgs e)
        {
            btn_addvehicle.FillColor = Color.Transparent;
            btn_addvehicle.FillColor2 = Color.Transparent;
        }

        
        private void btn_addvehicle_Click(object sender, EventArgs e)
        {
            using (var form = new VehicleAddForm())
            {
                form.StartPosition = FormStartPosition.CenterParent;
                var result = form.ShowDialog(this);
                if (result == DialogResult.OK
                    && _pages.TryGetValue(typeof(VehiclesPage), out var page)
                    && page is VehiclesPage vehiclesPage)
                {
                    vehiclesPage.RefreshVehicles();
                }
            }
        }
        private void DateTimePicker_changeDay_ValueChanged(object sender, EventArgs e)
        {
            AppClock.SetDate(DateTimePicker_changeDay.Value);
            ReservationManager.UpdateReservationStatuses(AppClock.Today);
            Enterprise.Instance.UpdateMaintenanceStates(AppClock.Today);
        }

        private void OnAppDateChanged(DateTime newDate)
        {
            if (DateTimePicker_changeDay.Value.Date != newDate.Date)
            {
                DateTimePicker_changeDay.Value = newDate.Date;
            }
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            DateTimePicker_changeDay.ValueChanged -= DateTimePicker_changeDay_ValueChanged;
            AppClock.DateChanged -= OnAppDateChanged;
            base.OnHandleDestroyed(e);
        }

        private void label_dashboard_Click(object sender, EventArgs e)
        {
            ShowPage<DashboardPage>("Dashboard");
        }
    }
}
