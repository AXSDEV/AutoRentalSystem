using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace AutoRentalSystem
{
    public abstract class Vehicle
    {
        public string RentState { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public string IsAvailable { get; set; }
        public string ShiftType { get; set; }
        public string FuelType { get; set; }
        public decimal DailyPrice { get; set; }
        public DateTime? AvailabilityDate { get; set; }
        public Vehicle(string rentState, string maker, string model, int year, string licensePlate, string isAvailable, string shiftType, string fuelType, decimal dailyPrice, DateTime? availabilityDate = null)
        {
            this.RentState = rentState;
            this.Maker = maker;
            this.Model = model;
            this.Year = year;
            this.LicensePlate = licensePlate;
            this.IsAvailable = isAvailable;
            this.ShiftType = shiftType;
            this.FuelType = fuelType;
            this.DailyPrice = dailyPrice;
            this.AvailabilityDate = availabilityDate;
        }
        public string VehicleType => GetType().Name;

        public string ShortDescription => $"{Maker} {Model} ({Year})";
        public override string ToString()
        {
            return $"{VehicleType} | {ShortDescription} | Matrícula: {LicensePlate} | Estado: {RentState} | Daily Price: {DailyPrice:C}"; return $"{VehicleType} | {ShortDescription} | Matrícula: {LicensePlate} | Estado: {RentState} | Daily Price: {DailyPrice:C}";
        }
    }
}