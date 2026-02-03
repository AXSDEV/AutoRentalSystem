using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRentalSystem
{
    public static class AppPaths
    {
        public static readonly string DataFolder =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");

        public static readonly string VehiclesFilePath =
            Path.Combine(DataFolder, "vehicles.csv");

        public static readonly string ReservationsFilePath =
            Path.Combine(DataFolder, "reservations.csv");
    }
}