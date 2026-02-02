using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRentalSystem
{

	public static class ReservationManager
	{
		private static readonly List<Reservation> _reservations = new List<Reservation>();
		private static int _nextReservationId = 1;
        private const decimal BaseDailyPrice = 50.0m;

        public static string ReservationsFilePath { get; set; } = string.Empty;
        public static string VehiclesFilePath { get; set; } = string.Empty;

        public static event Action ReservationsChanged;

        public static IReadOnlyList<Reservation> Reservations => _reservations.AsReadOnly();

        public static Reservation CreateReservation(Vehicle vehicle, DateTime startDate, DateTime endDate)
        {
            if (vehicle == null)
                throw new ArgumentNullException(nameof(vehicle), "Vehicle cannot be null.");

            if (endDate <= startDate)
                throw new ArgumentException("End date must be after start date.");

            if (!CheckAvailability(vehicle, startDate, endDate))
            {
                throw new InvalidOperationException(
                    $"The vehicle with license plate {vehicle.LicensePlate} is not available in the selected period.");
            }

            Reservation newReservation = new Reservation(_nextReservationId++, vehicle, startDate, endDate);
            newReservation.CalculatePrice(BaseDailyPrice);

            _reservations.Add(newReservation);

            var today = AppClock.Today.Date;

            if (startDate.Date > today)
            {
                vehicle.RentState = "Reserved";
                vehicle.AvailabilityDate = endDate.Date.AddDays(1);
            }
            else if (startDate.Date == today)
            {
                vehicle.RentState = "Rented";
                vehicle.AvailabilityDate = endDate.Date.AddDays(1);
            }


            PersistIfConfigured();
            PersistVehiclesIfConfigured();
            NotifyChanged();
            
            return newReservation;
        }

        private static void NotifyChanged()
        {
            var handler = ReservationsChanged;
            if (handler != null)
                handler();
        }

        private static void PersistIfConfigured()
        {
            if (string.IsNullOrWhiteSpace(ReservationsFilePath))
                return;

            SaveReservationsToFile(ReservationsFilePath);
        }

        private static void PersistVehiclesIfConfigured()
        {
            if (string.IsNullOrWhiteSpace(VehiclesFilePath))
                return;

            Enterprise.Instance.SaveVehiclesToCsv(VehiclesFilePath);
        }

        public static void LoadReservationsFromFile(IEnumerable<Vehicle> vehicles, string filePath)
        {
            if (vehicles == null)
                throw new ArgumentNullException(nameof(vehicles));

            var importedReservations = CsvExportService.ImportReservations(vehicles, filePath);
            _reservations.Clear();
            _reservations.AddRange(importedReservations);

            _nextReservationId = _reservations.Count == 0 ? 1 : _reservations.Max(r => r.Id) + 1;

            UpdateReservationStatuses(AppClock.Today);
            NotifyChanged();
        }

        public static void SaveReservationsToFile(string filePath)
        {
            CsvExportService.ExportReservations(_reservations, filePath);
        }

        public static Reservation UpdateReservation(
            int reservationId,
            DateTime startDate,
            DateTime endDate,
            ReservationStatus status)
        {
            var reservation = _reservations.FirstOrDefault(r => r.Id == reservationId);
            if (reservation == null)
            {
                throw new InvalidOperationException($"Reservation {reservationId} not found.");
            }

            if (endDate <= startDate)
            {
                throw new ArgumentException("End date must be after start date.");
            }

            if (!CheckAvailabilityForUpdate(reservation, startDate, endDate))
            {
                throw new InvalidOperationException(
                    $"The vehicle with license plate {reservation.Vehicle?.LicensePlate} is not available in the selected period.");
            }

            reservation.StartDate = startDate;
            reservation.EndDate = endDate;
            reservation.Status = status;
            reservation.CalculatePrice(BaseDailyPrice);

            PersistIfConfigured();
            NotifyChanged();

            return reservation;
        }

        public static void UpdateReservationStatuses(DateTime referenceDate)
        {
            if (_reservations.Count == 0)
            {
                return;
            }

            bool changed = false;

            foreach (var reservation in _reservations)
            {
                var previous = reservation.Status;
                reservation.UpdateStatus(referenceDate);
                if (reservation.Status != previous)
                {
                    changed = true;
                }
            }

            if (changed)
            {
                PersistIfConfigured();
            }

            NotifyChanged();
        }
        public static bool CheckAvailability(Vehicle vehicle, DateTime startDate, DateTime endDate)
		{
            if (vehicle.RentState == "Maintenance")
            {
                return false;
            }
            var timeConflict = _reservations.Any(r =>
				r.Vehicle == vehicle &&
				r.StartDate < endDate &&
				r.EndDate > startDate
				);
            if (vehicle.IsMaintenanceOverlap(startDate, endDate))
            {
                return false;
            }
            if (vehicle.AvailabilityDate.HasValue && vehicle.AvailabilityDate.Value > startDate)
			{
				return false;
			}

			return !timeConflict;
		}
        private static bool CheckAvailabilityForUpdate(Reservation reservation, DateTime startDate, DateTime endDate)
        {
            if (reservation?.Vehicle == null)
            {
                return false;
            }
            if (reservation.Vehicle.RentState == "Maintenance")
            {
                return false;
            }

            var timeConflict = _reservations.Any(r =>
                r.Id != reservation.Id &&
                r.Vehicle == reservation.Vehicle &&
                r.StartDate < endDate &&
                r.EndDate > startDate
                );
            if (reservation.Vehicle.IsMaintenanceOverlap(startDate, endDate))
            {
                return false;
            }

            if (reservation.Vehicle.AvailabilityDate.HasValue
                && reservation.Vehicle.AvailabilityDate.Value > startDate)
            {
                return false;
            }
            
            return !timeConflict;
        }

        public static decimal CalculateTotalPriceInterval(DateTime startDate, DateTime endDate)
		{
            if (endDate < startDate)
            {
                throw new ArgumentException("End date must be on or after start date.");
            }

            var intervalStart = startDate.Date;
            var intervalEnd = endDate.Date;

            return _reservations
                 .Where(r => r.Status == ReservationStatus.Completed
                    && r.StartDate.Date <= intervalEnd
                    && r.EndDate.Date >= intervalStart)
                    .Sum(r => r.TotalPrice);
        }
    }
}
