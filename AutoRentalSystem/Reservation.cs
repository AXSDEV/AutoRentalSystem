using System;

namespace AutoRentalSystem
{
	public class Reservation
	{
		public int Id { get; set; }
		public Vehicle Vehicle { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public decimal TotalPrice { get; set; }
		public bool IsCompleted { get; set; }

		public Reservation(int Id, Vehicle vehicle, DateTime startDate, DateTime endDate)
		{
			this.Id = Id;
			this.Vehicle = vehicle;
			this.StartDate = startDate;
			this.EndDate = endDate;
			this.IsCompleted = false;
		}

		public void CalculatePrice(decimal baseDailyPrice)
		{
			TimeSpan rentalDuration = EndDate - StartDate;
			int totalDays = (int)Math.Ceiling(rentalDuration.TotalDays);

			if (totalDays < 1) totalDays = 1;

            var dailyPrice = Vehicle?.DailyPrice > 0 ? Vehicle.DailyPrice : baseDailyPrice;
            TotalPrice = totalDays * dailyPrice;
        }

		public override string ToString()
		{
			return $"Reservation ID: {Id}, Vehicle: {Vehicle}, " + $"Start: {StartDate:dd/MM/yyyy}, End: {EndDate:dd/MM/yyyy}, " + $"Total: {TotalPrice:C}, Completed: {IsCompleted}";
		}
	}
}
