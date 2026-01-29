using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AutoRentalSystem
{
    public class Enterprise
    {
        private List<Vehicle> vehicles;
        public static Enterprise Instance { get; } = new Enterprise();
        public IReadOnlyList<Vehicle> Vehicles => vehicles.AsReadOnly();
        public Enterprise()
        {
            vehicles = new List<Vehicle>();
        }
        public bool AddVehicle(Vehicle vehicle)
        {
            if (vehicle == null)
                return false;

            if (vehicles.Any(v => string.Equals(v?.LicensePlate?.Trim(),vehicle.LicensePlate?.Trim(),StringComparison.OrdinalIgnoreCase)))
                return false;

            vehicles.Add(vehicle);
            return true;
        }

        public bool UpdateVehicle(string originalLicensePlate, Vehicle updatedVehicle)
        {
            if (updatedVehicle == null)
            {
                return false;
            }

            var existing = vehicles.FirstOrDefault(vehicle =>
                string.Equals(vehicle?.LicensePlate?.Trim(),
                    originalLicensePlate?.Trim(),
                    StringComparison.OrdinalIgnoreCase));

            if (existing == null)
            {
                return false;
            }

            var updatedPlate = updatedVehicle.LicensePlate?.Trim();
            if (!string.Equals(existing.LicensePlate?.Trim(), updatedPlate, StringComparison.OrdinalIgnoreCase)
                && vehicles.Any(vehicle =>
                    string.Equals(vehicle?.LicensePlate?.Trim(),
                        updatedPlate,
                        StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }

            var index = vehicles.IndexOf(existing);
            vehicles[index] = updatedVehicle;
            return true;
        }

        public bool RemoveVehicle(string licensePlate)
        {
            var existing = vehicles.FirstOrDefault(vehicle =>
                string.Equals(vehicle?.LicensePlate?.Trim(),
                    licensePlate?.Trim(),
                    StringComparison.OrdinalIgnoreCase));

            if (existing == null)
            {
                return false;
            }

            vehicles.Remove(existing);
            return true;
        }

        public void LoadVehiclesFromCsv(string filePath)
        {
            vehicles = File.Exists(filePath)
                ? CsvExportService.ImportVehicles(filePath)
                : new List<Vehicle>();
        }

        public void SaveVehiclesToCsv(string filePath)
        {
            CsvExportService.ExportVehicles(vehicles, filePath);
        }
        public Vehicle GetVehicleByLicensePlate(string licensePlate)
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
        public List<Vehicle> GetAvailableVehicles(string type = null)
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

