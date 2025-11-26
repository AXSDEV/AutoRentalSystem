using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace AutoRentalSystem
{
    internal class Car : Vehicle
    {
        int NumberDoors { get; set; }
        string ShiftType { get; set; }
        string FuelType { get; set; }

        public Car(string maker, string model, int year, string licensePlate, string IsAvailable, int numberDoors, string shiftType, string fuelType) : base(maker, model, year, licensePlate, IsAvailable)
        {
            this.NumberDoors = numberDoors;
            this.ShiftType = shiftType;
            this.FuelType = fuelType;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - {NumberDoors} doors, {ShiftType}, {FuelType}";
        }
    }
}
