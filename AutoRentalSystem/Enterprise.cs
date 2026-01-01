using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRentalSystem
{
    public class Enterprise
    {
        private List<Vehicle> vehicles;
        public Enterprise()
        {
            vehicles = new List<Vehicle>();
        }
        public bool AddVehicle(Vehicle vehicle)
        {
            if (vehicle == null)
                return false;

            if (vehicles.Any(v => v.LicensePlate == vehicle.LicensePlate))
                return false;

            vehicles.Add(vehicle);
            return true;
        }
        public Vehicle? GetVehicleByLicensePlate(string licensePlate)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.LicensePlate == licensePlate)
                {
                    return vehicle;
                }
            }
            return null;
        }
        public bool ChangeVehicleState(string licensePlate, string newState, DateTime? availabilityDate = null)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.LicensePlate == licensePlate)
                {
                    vehicle.RentState = newState;

                    if (newState == "Available")
                    {
                        vehicle.AvailabilityDate = DateTime.Today;
                        return true;
                    }
                    if (availabilityDate.HasValue)
                    {
                        vehicle.AvailabilityDate = availabilityDate.Value;
                    }
                    return true;
                }
            }
            return false;
        }
        public List<Vehicle> GetAvailableVehicles(string? type = null)
        {
            List<Vehicle> result = new List<Vehicle>();

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.RentState == "Available")
                {
                    if (type == null || vehicle.GetType().Name == type)
                    {
                        result.Add(vehicle);
                    }
                }
            }
            return result;
        }
        public List<Vehicle> GetVehiclesInMaintenance()
        {
            List<Vehicle> result = new List<Vehicle>();

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.RentState == "Maintenance")
                {
                    result.Add(vehicle);
                }
            }
            return result;
        }
    }
}

