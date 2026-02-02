using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;


namespace AutoRentalSystem
{
    public partial class DashboardPage : UserControl
    {

        private readonly string _vehiclesFilePath = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
        "data",
        "vehicles.csv");
        private bool _eventsHooked;

        public DashboardPage()
        {
            InitializeComponent();
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            if (_eventsHooked)
            {
                return;
            }

            Load += DashboardPage_Load;
            dateTimePicker_startDate.ValueChanged += HandleDateRangeChanged;
            dateTimePicker_endDate.ValueChanged += HandleDateRangeChanged;
            ReservationManager.ReservationsChanged += HandleReservationsChanged;
            Enterprise.Instance.VehiclesChanged += HandleVehiclesChanged;
            AppClock.DateChanged += HandleDateChanged;
            _eventsHooked = true;
        }

        private void DashboardPage_Load(object sender, EventArgs e)
        {
            label1.Text = "Dashboard";
            InitializeDatePickers();
            RefreshDashboard();
        }

        private void InitializeDatePickers()
        {
            var today = AppClock.Today;
            dateTimePicker_endDate.Value = today;
            dateTimePicker_startDate.Value = today.AddDays(-30);
        }

        private void HandleDateRangeChanged(object sender, EventArgs e)
        {
            var start = dateTimePicker_startDate.Value.Date;
            var end = dateTimePicker_endDate.Value.Date;

            if (end < start)
            {
                dateTimePicker_startDate.Value = start;
            }

            UpdateIncomeInterval();
            UpdateRentChart();
        }

        private void HandleReservationsChanged()
        {
            UpdateRevenueTotal();
            UpdateIncomeInterval();
            UpdateRentChart();
        }
        private void HandleVehiclesChanged()
        {
            UpdateVehicleStats();
        }
        private void HandleDateChanged(DateTime newDate)
        {
            RefreshDashboard();
        }

        public void RefreshDashboard()
        {
            LoadVehicles();
            UpdateVehicleStats();
            UpdateRevenueTotal();
            UpdateIncomeInterval();
            UpdateRentChart();
        }

        private void LoadVehicles()
        {
            if (File.Exists(_vehiclesFilePath))
            {
                Enterprise.Instance.LoadVehiclesFromCsv(_vehiclesFilePath);
                Enterprise.Instance.UpdateMaintenanceStates(AppClock.Today);
            }
        }

        private void UpdateVehicleStats()
        {
            var vehicles = Enterprise.Instance.Vehicles.Where(v => v != null).ToList();
            label_totalVehicles_info.Text = vehicles.Count.ToString();

            var rentedCount = vehicles.Count(vehicle =>
            {
                var state = vehicle.RentState?.Trim();
                return string.Equals(state, "Rented", StringComparison.OrdinalIgnoreCase);

            });
            label_rentedVehicles_info.Text = rentedCount.ToString();

            var maintenanceCount = vehicles.Count(vehicle =>
                string.Equals(vehicle.RentState?.Trim(), "Maintenance", StringComparison.OrdinalIgnoreCase));
            label_maintenance_info.Text = maintenanceCount.ToString();
        }

        private void UpdateRevenueTotal()
        {
            var totalRevenue = ReservationManager.Reservations
                .Where(r => r.Status == ReservationStatus.Completed)
                .Sum(r => r.TotalPrice);
            label_totalRevenue_info.Text = totalRevenue.ToString("C");
        }

        private void UpdateIncomeInterval()
        {
            var start = dateTimePicker_startDate.Value.Date;
            var end = dateTimePicker_endDate.Value.Date;
            var income = ReservationManager.CalculateTotalPriceInterval(start, end);
            label_income_info.Text = income.ToString("C");
        }

        private void UpdateRentChart()
        {
            UpdateRentsByVehicleType();
            UpdateRentsPerMonth();
        }

        private void UpdateRentsByVehicleType()
        {
            if (chart_rentsVehicleType.Series.Count == 0)
            {
                chart_rentsVehicleType.Series.Add(new Series("Series1"));
            }

            var series = chart_rentsVehicleType.Series[0];
            series.Points.Clear();
            series.ChartType = SeriesChartType.Pie;

            var grouped = ReservationManager.Reservations
                .Where(r => r.Vehicle != null)
                .GroupBy(r => r.Vehicle.VehicleType)
                .Select(g => new { VehicleType = g.Key, Total = g.Count() })
                .OrderByDescending(item => item.Total)
                .ToList();

            foreach (var item in grouped)
            {
                series.Points.AddXY(item.VehicleType, item.Total);
            }
        }

        private void UpdateRentsPerMonth()
        {
            if (chart_rentsMonth.Series.Count == 0)
            {
                chart_rentsMonth.Series.Add(new Series("Series1") { ChartType = SeriesChartType.SplineArea });
            }

            var series = chart_rentsMonth.Series[0];
            series.Points.Clear();

            var start = dateTimePicker_startDate.Value.Date;
            var end = dateTimePicker_endDate.Value.Date;

            var rentsByMonth = ReservationManager.Reservations
                .Where(r => r.StartDate.Date <= end && r.EndDate.Date >= start)
                .GroupBy(r => new DateTime(r.StartDate.Year, r.StartDate.Month, 1))
                .ToDictionary(g => g.Key, g => g.Count());

            var currentMonth = new DateTime(start.Year, start.Month, 1);
            var lastMonth = new DateTime(end.Year, end.Month, 1);

            while (currentMonth <= lastMonth)
            {
                int count = rentsByMonth.TryGetValue(currentMonth, out int c) ? c : 0;
                string label = currentMonth.ToString("MMM yyyy", new System.Globalization.CultureInfo("pt-PT"));
                series.Points.AddXY(label, count);
                currentMonth = currentMonth.AddMonths(1);
            }
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            if (_eventsHooked)
            {
                Load -= DashboardPage_Load;
                dateTimePicker_startDate.ValueChanged -= HandleDateRangeChanged;
                dateTimePicker_endDate.ValueChanged -= HandleDateRangeChanged;
                ReservationManager.ReservationsChanged -= HandleReservationsChanged;
                Enterprise.Instance.VehiclesChanged -= HandleVehiclesChanged;
                AppClock.DateChanged -= HandleDateChanged;
                _eventsHooked = false;
            }

            base.OnHandleDestroyed(e);
        }
    }
}