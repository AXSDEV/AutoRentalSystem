using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRentalSystem
{
    internal class Mota : Vehicle
    {
        public int Cc { get; set; }
        public Mota(string rentState, string maker, string model, int year, string licensePlate, string isAvailable, string shiftType, string fuelType, int cc) : base(rentState, maker, model, year, licensePlate, isAvailable, shiftType, fuelType)
        {
            this.Cc = cc;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - {Cc} cc";
        }



    }
}
