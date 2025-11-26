using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRentalSystem
{
    internal class Bus : Vehicle
    {
        public int AxelNumber { get; set; }
        public int MaxPax { get; set; }
        public Bus(string maker, string model, int year, string licensePlate, string isAvailable, string shiftType, string fuelType, int axelNumber, int maxPax) : base(maker, model, year, licensePlate, isAvailable, shiftType, fuelType)
        {
            this.AxelNumber = axelNumber;
            this.MaxPax = maxPax;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {AxelNumber} axel number, {MaxPax}- NºMax passageiros";
        }



    }
}
