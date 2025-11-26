using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRentalSystem
{
    abstract class Vehicle
    {
        public string Maker { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public string IsAvailable { get; set; }
        public Vehicle(string maker, string model, int year, string licensePlate, string isAvailable)
        {
            Maker = maker;
            Model = model;
            Year = year;
            LicensePlate = licensePlate;
            IsAvailable = isAvailable;
            
        }
    }
}
