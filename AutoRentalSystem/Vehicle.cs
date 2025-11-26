using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace AutoRentalSystem
{
    abstract class Vehicle
    {
        public string Maker { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public string IsAvailable { get; set; }
        public string ShiftType { get; set; }
        public string FuelType { get; set; }
        public Vehicle(string maker, string model, int year, string licensePlate, string isAvailable,string shiftType, string fuelType)
        {
            this.Maker = maker;
            this.Model = model;
            this.Year = year;
            this.LicensePlate = licensePlate;
            this.IsAvailable = isAvailable;
            this.ShiftType = shiftType;
            this.FuelType = fuelType;

        }
    }
}
