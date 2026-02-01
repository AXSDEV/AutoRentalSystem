using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace AutoRentalSystem
{
    public static class CsvExportService
    {
        public static void ExportVehicles(IEnumerable<Vehicle> vehicles, string filePath)
        {
            if (vehicles == null)
            {
                throw new ArgumentNullException(nameof(vehicles));
            }

            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException("File path cannot be empty.", nameof(filePath));
            }

            var builder = new StringBuilder();

            foreach (var vehicle in vehicles)
            {
                AppendAttribute(builder, "VehicleType", vehicle?.GetType().Name);
                AppendAttribute(builder, "RentState", vehicle?.RentState);
                AppendAttribute(builder, "Maker", vehicle?.Maker);
                AppendAttribute(builder, "Model", vehicle?.Model);
                AppendAttribute(builder, "Year", FormatInt(vehicle?.Year));
                AppendAttribute(builder, "LicensePlate", vehicle?.LicensePlate);
                AppendAttribute(builder, "IsAvailable", vehicle?.IsAvailable);
                AppendAttribute(builder, "ShiftType", vehicle?.ShiftType);
                AppendAttribute(builder, "FuelType", vehicle?.FuelType);
                AppendAttribute(builder, "DailyPrice", FormatDecimal(vehicle?.DailyPrice));
                AppendAttribute(builder, "AvailabilityDate", FormatDate(vehicle?.AvailabilityDate));
                AppendAttribute(builder, "NumberDoors", GetNumberDoors(vehicle));
                AppendAttribute(builder, "AxelNumber", GetAxelNumber(vehicle));
                AppendAttribute(builder, "MaxPax", GetMaxPax(vehicle));
                AppendAttribute(builder, "Height", GetHeight(vehicle));
                AppendAttribute(builder, "MaxWeight", GetMaxWeight(vehicle));
                AppendAttribute(builder, "Cc", GetCc(vehicle));
                builder.AppendLine();
            }

            File.WriteAllText(filePath, builder.ToString(), Encoding.UTF8);
        }

        public static List<Vehicle> ImportVehicles(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException("File path cannot be empty.", nameof(filePath));
            }

            var content = File.ReadAllText(filePath, Encoding.UTF8);
            var blocks = ParseBlocks(content);
            var vehicles = new List<Vehicle>();

            foreach (var block in blocks)
            {
                var vehicle = CreateVehicleFromBlock(block);
                if (vehicle != null)
                {
                    vehicles.Add(vehicle);
                }
            }

            return vehicles;
        }

        public static void ExportReservations(IEnumerable<Reservation> reservations, string filePath)
        {
            if (reservations == null)
            {
                throw new ArgumentNullException(nameof(reservations));
            }

            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException("File path cannot be empty.", nameof(filePath));
            }

            var builder = new StringBuilder();

            foreach (var reservation in reservations)
            {
                AppendAttribute(builder, "Id", FormatInt(reservation?.Id));
                AppendAttribute(builder, "VehicleType", reservation?.Vehicle?.GetType().Name);
                AppendAttribute(builder, "LicensePlate", reservation?.Vehicle?.LicensePlate);
                AppendAttribute(builder, "StartDate", FormatDate(reservation?.StartDate));
                AppendAttribute(builder, "EndDate", FormatDate(reservation?.EndDate));
                AppendAttribute(builder, "TotalPrice", FormatDecimal(reservation?.TotalPrice));
                AppendAttribute(builder, "Status", FormatStatus(reservation?.Status));
                builder.AppendLine();
            }

            File.WriteAllText(filePath, builder.ToString(), Encoding.UTF8);
        }

        public static List<Reservation> ImportReservations(IEnumerable<Vehicle> vehicles, string filePath)
        {
            if (vehicles == null)
            {
                throw new ArgumentNullException(nameof(vehicles));
            }

            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException("File path cannot be empty.", nameof(filePath));
            }

            var content = File.ReadAllText(filePath, Encoding.UTF8);
            var blocks = ParseBlocks(content);
            var reservations = new List<Reservation>();
            var vehicleByPlate = vehicles
                .Where(vehicle => vehicle != null && !string.IsNullOrWhiteSpace(vehicle.LicensePlate))
                .ToDictionary(vehicle => vehicle.LicensePlate, StringComparer.OrdinalIgnoreCase);

            foreach (var block in blocks)
            {
                var reservation = CreateReservationFromBlock(block, vehicleByPlate);
                if (reservation != null)
                {
                    reservations.Add(reservation);
                }
            }

            return reservations;
        }

        private static string FormatDate(DateTime? value)
        {
            return value?.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) ?? string.Empty;
        }

        private static string FormatInt(int? value)
        {
            return value?.ToString(CultureInfo.InvariantCulture) ?? string.Empty;
        }

        private static string FormatDecimal(decimal? value)
        {
            return value?.ToString(CultureInfo.InvariantCulture) ?? string.Empty;
        }

        private static string FormatStatus(ReservationStatus? status)
        {
            return status?.ToString() ?? string.Empty;
        }

        private static void AppendAttribute(StringBuilder builder, string attribute, string value)
        {
            builder.AppendLine($"{attribute}: {value ?? string.Empty}");
        }

        private static void AppendAttribute(StringBuilder builder, string attribute, int value)
        {
            builder.AppendLine($"{attribute}: {value}");
        }

        private static List<Dictionary<string, string>> ParseBlocks(string content)
        {
            var blocks = new List<Dictionary<string, string>>();
            var current = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            if (string.IsNullOrWhiteSpace(content))
            {
                return blocks;
            }

            var lines = content.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            foreach (var rawLine in lines)
            {
                var line = rawLine?.Trim();
                if (string.IsNullOrWhiteSpace(line))
                {
                    if (current.Count > 0)
                    {
                        blocks.Add(current);
                        current = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                    }
                    continue;
                }

                var separatorIndex = line.IndexOf(':');
                if (separatorIndex <= 0)
                {
                    continue;
                }

                var key = line.Substring(0, separatorIndex).Trim();
                var value = line.Substring(separatorIndex + 1).Trim();
                current[key] = Unquote(value);
            }

            if (current.Count > 0)
            {
                blocks.Add(current);
            }

            return blocks;
        }

        private static string Unquote(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            if (value.Length >= 2 && value.StartsWith("\"") && value.EndsWith("\""))
            {
                return value.Substring(1, value.Length - 2);
            }

            return value;
        }

        private static Vehicle CreateVehicleFromBlock(Dictionary<string, string> block)
        {
            block.TryGetValue("VehicleType", out var type);
            block.TryGetValue("RentState", out var rentState);
            block.TryGetValue("Maker", out var maker);
            block.TryGetValue("Model", out var model);
            block.TryGetValue("Year", out var yearText);
            block.TryGetValue("LicensePlate", out var licensePlate);
            block.TryGetValue("IsAvailable", out var isAvailable);
            block.TryGetValue("ShiftType", out var shiftType);
            block.TryGetValue("FuelType", out var fuelType);
            block.TryGetValue("DailyPrice", out var dailyPriceText);
            block.TryGetValue("AvailabilityDate", out var availabilityDateText);

            var year = ParseInt(yearText);
            var dailyPrice = ParseDecimal(dailyPriceText);
            var availabilityDate = ParseDate(availabilityDateText);

            switch (type)
            {
                case nameof(Car):
                    block.TryGetValue("NumberDoors", out var doorsText);
                    return new Car(rentState, maker, model, year, licensePlate, isAvailable, ParseInt(doorsText), shiftType, fuelType, dailyPrice)
                    {
                        AvailabilityDate = availabilityDate
                    };
                case nameof(Bus):
                    block.TryGetValue("AxelNumber", out var axelText);
                    block.TryGetValue("MaxPax", out var maxPaxText);
                    return new Bus(rentState, maker, model, year, licensePlate, isAvailable, shiftType, fuelType, ParseInt(axelText), ParseInt(maxPaxText), dailyPrice)
                    {
                        AvailabilityDate = availabilityDate
                    };
                case nameof(Truck):
                    block.TryGetValue("MaxWeight", out var maxWeightText);
                    block.TryGetValue("Height", out var heightText);
                    return new Truck(rentState, maker, model, year, licensePlate, isAvailable, shiftType, fuelType, ParseInt(maxWeightText), ParseInt(heightText), dailyPrice)
                    {
                        AvailabilityDate = availabilityDate
                    };
                case nameof(Motorcycle):
                    block.TryGetValue("Cc", out var ccText);
                    return new Motorcycle(rentState, maker, model, year, licensePlate, isAvailable, shiftType, fuelType, ParseInt(ccText), dailyPrice)
                    {
                        AvailabilityDate = availabilityDate
                    };
                default:
                    return null;
            }
        }

        private static Reservation CreateReservationFromBlock(
            Dictionary<string, string> block,
            Dictionary<string, Vehicle> vehicleByPlate)
        {
            block.TryGetValue("Id", out var idText);
            block.TryGetValue("LicensePlate", out var licensePlate);
            block.TryGetValue("StartDate", out var startDateText);
            block.TryGetValue("EndDate", out var endDateText);
            block.TryGetValue("TotalPrice", out var totalPriceText);
            block.TryGetValue("Status", out var statusText);
            block.TryGetValue("IsCompleted", out var isCompletedText);

            if (string.IsNullOrWhiteSpace(licensePlate))
            {
                return null;
            }

            if (!vehicleByPlate.TryGetValue(licensePlate, out var vehicle))
            {
                return null;
            }

            var startDate = ParseDate(startDateText);
            var endDate = ParseDate(endDateText);
            if (!startDate.HasValue || !endDate.HasValue)
            {
                return null;
            }

            var reservation = new Reservation(ParseInt(idText), vehicle, startDate.Value, endDate.Value)
            {
                TotalPrice = ParseDecimal(totalPriceText)
            };
            reservation.Status = ParseStatus(statusText, isCompletedText, reservation.StartDate, reservation.EndDate);

            return reservation;
        }

        private static int ParseInt(string value)
        {
            return int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed)
                ? parsed
                : 0;
        }

        private static decimal ParseDecimal(string value)
        {
            return decimal.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out var parsed)
                ? parsed
                : 0m;
        }

        private static ReservationStatus ParseStatus(
            string statusText,
            string isCompletedText,
            DateTime startDate,
            DateTime endDate)
        {
            if (Enum.TryParse(statusText, true, out ReservationStatus parsedStatus))
            {
                return parsedStatus;
            }

            if (bool.TryParse(isCompletedText, out var isCompleted) && isCompleted)
            {
                return ReservationStatus.Completed;
            }

            var today = AppClock.Today;
            if (today >= endDate.Date)
            {
                return ReservationStatus.Completed;
            }

            if (today >= startDate.Date)
            {
                return ReservationStatus.Active;
            }

            return ReservationStatus.Reserved;
        }

        private static DateTime? ParseDate(string value)
        {
            return DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsed)
                ? parsed
                : (DateTime?)null;
        }

        private static int GetNumberDoors(Vehicle vehicle)
        {
            return vehicle is Car car ? car.NumberDoors : 0;
        }

        private static int GetAxelNumber(Vehicle vehicle)
        {
            return vehicle is Bus bus ? bus.AxelNumber : 0;
        }

        private static int GetMaxPax(Vehicle vehicle)
        {
            return vehicle is Bus bus ? bus.MaxPax : 0;
        }

        private static int GetHeight(Vehicle vehicle)
        {
            return vehicle is Truck truck ? truck.Height : 0;
        }

        private static int GetMaxWeight(Vehicle vehicle)
        {
            return vehicle is Truck truck ? truck.MaxWeight : 0;
        }

        private static int GetCc(Vehicle vehicle)
        {
            return vehicle is Motorcycle motorcycle ? motorcycle.Cc : 0;
        }
    }
}
