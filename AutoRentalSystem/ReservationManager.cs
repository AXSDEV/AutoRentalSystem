using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRentalSystem
{

	public static class ReservationManager
	{
		private static List<Reservation> _reservations = new List<Reservation>();
		private static int _nextReservationId = 1;
		private const decimal BaseDailyPrice = 50.0m;

		public static IReadOnlyList<ReservationManager> Reservations => _reservations.AsReadOnly();
		public static Reservation CreateReservation(Vehicle vehicle, DateTime startDate, DateTime endDate)
		{
			if (endDate <= startDate)
			{
				throw new ArgumentException("End date must be after start date.");
			}
			if (!CheckAvailability(vehicle, startDate, endDate))
			{
				throw new InvalidOperationException("The vehicle whit license plate {vehicle.LicensePlate} is not available in the selected period.");
			}
			Reservation newReservation = new Reservation(_nextReservationId++, vehicle, startDate, endDate);

			newReservation.CalculatePrice(BaseDailyPrice);

			_reservations.Add(newReservation);

			vehicle.RentState = "Reserved";
			vehicle.AvailabilityDate = endDate.AddDays(1);

			return newReservation;
		}

		public static bool CheckAvailability(Vehicle vehicle, DateTime startDate, DateTime endDate)
		{
			var conflicts = _reservations.Any(r =>
				r.Vehicle == vehicle &&
				r.StartDate < endDate &&
				r.EndDate > startDate
				);

			if (vehicle.AvailabilityDate > startDate)
			{
				return false;
			}

			return !conflicts;
		}

		public static decimal CalculateTotalInvoiced(DateTime startDate, DateTime endDate)
		{
			return _reservations
				.Where(r => r.IsCompleted && r.StartDate >= startDate && r.EndDate <= endDate)
				.Sum(r => r.TotalPrice);
		}
	}
}
