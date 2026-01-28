using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AutoRentalSystem
{
    public partial class VehicleAddForm : Form
    {
        
        public event EventHandler<VehicleSavedEventArgs> VehicleSaved;
        public Vehicle SavedVehicle { get; private set; }

        private readonly string _vehiclesFilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "data",
            "vehicles.csv");

        private UC_AddVehicleForm_Car_Background ucCar;
        private UC_AddVehicleForm_Bike ucBike;
        private UC_AddVehicleForm_Bus ucBus;
        private UC_AddVehicleForm_Truck ucTruck;

        public VehicleAddForm()
        {
            InitializeComponent();
            this.BackColor = Color.Black;

            ucCar = new UC_AddVehicleForm_Car_Background { Dock = DockStyle.Fill, Visible = false };
            ucBike = new UC_AddVehicleForm_Bike { Dock = DockStyle.Fill, Visible = false };
            ucBus = new UC_AddVehicleForm_Bus { Dock = DockStyle.Fill, Visible = false };
            ucTruck = new UC_AddVehicleForm_Truck { Dock = DockStyle.Fill, Visible = false };

            panel_AddVehicleForm_Content.Controls.Add(ucCar);
            panel_AddVehicleForm_Content.Controls.Add(ucBike);
            panel_AddVehicleForm_Content.Controls.Add(ucBus);
            panel_AddVehicleForm_Content.Controls.Add(ucTruck);

            ucCar.AddVehicleRequested += HandleAddCar;
            ucBike.AddVehicleRequested += HandleAddBike;
            ucBus.AddVehicleRequested += HandleAddBus;
            ucTruck.AddVehicleRequested += HandleAddTruck;
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

        private void ShowVehiclePanel(Control panelToShow)
        {
            foreach (Control c in panel_AddVehicleForm_Content.Controls)
                c.Visible = false;

            panelToShow.Visible = true;
            panelToShow.BringToFront();
        }

        private void btn_AddVehicleForm_Car_Click(object sender, EventArgs e) => ShowVehiclePanel(ucCar);
        private void btn_AddVehicleForm_Bike_Click(object sender, EventArgs e) => ShowVehiclePanel(ucBike);
        private void btn_AddVehicleForm_Bus_Click(object sender, EventArgs e) => ShowVehiclePanel(ucBus);
        private void btn_AddVehicleForm_Truck_Click(object sender, EventArgs e) => ShowVehiclePanel(ucTruck);

        private void HandleAddCar(object sender, EventArgs e)
        {
            if (!TryGetBaseVehicleData(out var baseData)) return;
            if (!TryParseInt(ucCar.NumberOfDoorsText, "Number of doors", out var numberDoors)) return;

            var vehicle = new Car(
                baseData.RentState,
                baseData.Maker,
                baseData.Model,
                baseData.Year,
                baseData.LicensePlate,
                baseData.IsAvailable,
                numberDoors,
                baseData.ShiftType,
                baseData.FuelType,
                baseData.DailyPrice)
            {
                AvailabilityDate = baseData.AvailabilityDate
            };

            SaveVehicle(vehicle);
        }

        private void HandleAddBike(object sender, EventArgs e)
        {
            if (!TryGetBaseVehicleData(out var baseData)) return;
            if (!TryParseInt(ucBike.CcText, "Cubic capacity", out var cc)) return;

            var vehicle = new Motorcycle(
                baseData.RentState,
                baseData.Maker,
                baseData.Model,
                baseData.Year,
                baseData.LicensePlate,
                baseData.IsAvailable,
                baseData.ShiftType,
                baseData.FuelType,
                cc,
                baseData.DailyPrice)
            {
                AvailabilityDate = baseData.AvailabilityDate
            };

            SaveVehicle(vehicle);
        }

        private void HandleAddBus(object sender, EventArgs e)
        {
            if (!TryGetBaseVehicleData(out var baseData)) return;
            if (!TryParseInt(ucBus.MaxPassengerText, "Maximum passengers", out var maxPax)) return;
            if (!TryParseInt(ucBus.AxelNumberText, "Axel number", out var axelNumber)) return;

            var vehicle = new Bus(
                baseData.RentState,
                baseData.Maker,
                baseData.Model,
                baseData.Year,
                baseData.LicensePlate,
                baseData.IsAvailable,
                baseData.ShiftType,
                baseData.FuelType,
                axelNumber,
                maxPax,
                baseData.DailyPrice)
            {
                AvailabilityDate = baseData.AvailabilityDate
            };

            SaveVehicle(vehicle);
        }

        private void HandleAddTruck(object sender, EventArgs e)
        {
            if (!TryGetBaseVehicleData(out var baseData)) return;
            if (!TryParseInt(ucTruck.MaxWeightText, "Max weight", out var maxWeight)) return;
            if (!TryParseInt(ucTruck.HeightText, "Height", out var height)) return;

            var vehicle = new Truck(
                baseData.RentState,
                baseData.Maker,
                baseData.Model,
                baseData.Year,
                baseData.LicensePlate,
                baseData.IsAvailable,
                baseData.ShiftType,
                baseData.FuelType,
                maxWeight,
                height,
                baseData.DailyPrice)
            {
                AvailabilityDate = baseData.AvailabilityDate
            };

            SaveVehicle(vehicle);
        }

        private bool TryGetBaseVehicleData(out VehicleBaseData baseData)
        {
            baseData = default;

            var licensePlate = GetRequiredText(guna2TextBox1, "License plate");
            var fuelType = GetRequiredText(guna2TextBox2, "Fuel type");
            var maker = GetRequiredText(guna2TextBox3, "Maker");
            var model = GetRequiredText(guna2TextBox4, "Model");
            var yearText = GetRequiredText(guna2TextBox5, "Year");
            var shiftType = GetRequiredText(guna2TextBox6, "Shift type");
            var dailyPriceText = GetRequiredText(guna2TextBox7, "Daily price");
            var rentState = "Available";
            var isAvailable = "True";
            DateTime? availabilityDate = DateTime.Today;
            if (string.IsNullOrWhiteSpace(licensePlate)
                || string.IsNullOrWhiteSpace(fuelType)
                || string.IsNullOrWhiteSpace(maker)
                || string.IsNullOrWhiteSpace(model)
                || string.IsNullOrWhiteSpace(yearText)
                || string.IsNullOrWhiteSpace(shiftType)
                || string.IsNullOrWhiteSpace(dailyPriceText))
                
            {
                return false;
            }

            if (!TryParseInt(yearText, "Year", out var year))
                return false;

            if (!TryParseDecimal(dailyPriceText, "Daily price", out var dailyPrice))
                return false;

            baseData = new VehicleBaseData(
                rentState,
                maker,
                model,
                year,
                licensePlate,
                isAvailable,
                shiftType,
                fuelType,
                dailyPrice,
                availabilityDate);

            return true;
        }

        private string GetRequiredText(Guna2TextBox textBox, string fieldName)
        {
            var value = textBox.Text?.Trim();
            if (string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show(
                    $"Please enter a value for {fieldName}.",
                    "Missing data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return null;
            }

            return value;
        }

        private bool TryParseInt(string value, string fieldName, out int parsed)
        {
            if (!int.TryParse(value, NumberStyles.Integer, CultureInfo.CurrentCulture, out parsed))
            {
                MessageBox.Show(
                    $"{fieldName} must be a valid number.",
                    "Invalid data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool TryParseDecimal(string value, string fieldName, out decimal parsed)
        {
            if (!decimal.TryParse(value, NumberStyles.Number, CultureInfo.CurrentCulture, out parsed))
            {
                MessageBox.Show(
                    $"{fieldName} must be a valid amount.",
                    "Invalid data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void SaveVehicle(Vehicle vehicle)
        {
            if (vehicle == null) return;

            var vehicles = new List<Vehicle>();
            if (File.Exists(_vehiclesFilePath))
            {
                vehicles = CsvExportService.ImportVehicles(_vehiclesFilePath);
            }

          
            if (vehicles.Any(existing =>
                string.Equals(existing?.LicensePlate?.Trim(),
                              vehicle.LicensePlate?.Trim(),
                              StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show(
                    "A vehicle with the same license plate already exists.",
                    "Duplicate vehicle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            vehicles.Add(vehicle);

            var directory = Path.GetDirectoryName(_vehiclesFilePath);
            if (!string.IsNullOrWhiteSpace(directory))
            {
                Directory.CreateDirectory(directory);
            }

            CsvExportService.ExportVehicles(vehicles, _vehiclesFilePath);

            
            SavedVehicle = vehicle;
            VehicleSaved?.Invoke(this, new VehicleSavedEventArgs(vehicle));

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public class VehicleSavedEventArgs : EventArgs
        {
            public VehicleSavedEventArgs(Vehicle vehicle) => Vehicle = vehicle;
            public Vehicle Vehicle { get; }
        }

        private readonly struct VehicleBaseData
        {
            public VehicleBaseData(
                string rentState,
                string maker,
                string model,
                int year,
                string licensePlate,
                string isAvailable,
                string shiftType,
                string fuelType,
                decimal dailyPrice,
                DateTime? availabilityDate)
            {
                RentState = rentState;
                Maker = maker;
                Model = model;
                Year = year;
                LicensePlate = licensePlate;
                IsAvailable = isAvailable;
                ShiftType = shiftType;
                FuelType = fuelType;
                DailyPrice = dailyPrice;
                AvailabilityDate = availabilityDate;
            }

            public string RentState { get; }
            public string Maker { get; }
            public string Model { get; }
            public int Year { get; }
            public string LicensePlate { get; }
            public string IsAvailable { get; }
            public string ShiftType { get; }
            public string FuelType { get; }
            public decimal DailyPrice { get; }
            public DateTime? AvailabilityDate { get; }
        }
    }
}
