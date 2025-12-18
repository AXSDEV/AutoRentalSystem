using System;
namespace AutoRentalSystem
{
    public class Enterprise
    {
        private List<Vehicle> vehicles;
        public Enterprise()
        {
            vehicles = new list<Vehicle>();
        }
        public bool AddVehicle(Vehicle vehicle)
        {
            if (vehicle == null)
                return false;

            if (vehicles.Any(v => v.licensePlate == vehicle.licensePlate))
                return false;

            vehicles.Add(vehicle);
            return true;
        }
        public Vehicle? GetVehicleByLicensePlate(string licensePlate)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.licensePlate == licensePlate)
                {
                    return vehicle;
                }
                return null;
            }
        }
        public bool ChangeVehicleState(string licensePlate, string newState, DateTime? availabilityDate = null)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.licensePlate == licensePlate)
                {
                    vehicle.RentState = newState;

                    if (newState == "Available")
                    {
                        vehicle.availabilityDate = DateTime.Today;
                        return true;
                    }
                    if (availabilityDate.HasValue)
                    {
                        vehicle.availabilityDate = availabilityDate.Value;
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

