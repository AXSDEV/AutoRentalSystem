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
        public int NumberDoors { get; set; }

        public Car(string rentState, string maker, string model, int year, string licensePlate, string IsAvailable, int numberDoors, string shiftType, string fuelType) : base(rentState, maker, model, year, licensePlate, IsAvailable, shiftType, fuelType)
        {
            this.NumberDoors = numberDoors;

        }
        public override string ToString()
        {
            return $"{base.ToString()} - {NumberDoors} doors, {ShiftType}, {FuelType}";
        }
    }
}
