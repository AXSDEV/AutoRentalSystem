using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRentalSystem
{
    internal class Truck : Vehicle
    {
        public int Height { get; set; }
        public int MaxWeight { get; set; }
        public Truck(string maker, string model, int year, string licensePlate, string isAvailable, string shiftType, string fuelType, int maxWeight, int height) : base(maker, model, year, licensePlate, isAvailable, shiftType, fuelType)
        {
            this.MaxWeight = maxWeight;
            this.Height = height;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - {Height} :Heigth, - {MaxWeight} :Weight";
        }
    }
}
