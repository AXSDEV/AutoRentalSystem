using System;

namespace AutoRentalSystem
{
    public enum ReservationStatus
    {
        Reserved,
        Active,
        Completed
    }

    public class Reservation
	{
		public int Id { get; set; }
		public Vehicle Vehicle { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public decimal TotalPrice { get; set; }
        public ReservationStatus Status { get; set; }
        public bool IsCompleted => Status == ReservationStatus.Completed;

        public Reservation(int Id, Vehicle vehicle, DateTime startDate, DateTime endDate)
		{
			this.Id = Id;
			this.Vehicle = vehicle;
			this.StartDate = startDate;
			this.EndDate = endDate;
            this.Status = ReservationStatus.Reserved;
        }

		public void CalculatePrice(decimal baseDailyPrice)
		{
			TimeSpan rentalDuration = EndDate - StartDate;
			int totalDays = (int)Math.Ceiling(rentalDuration.TotalDays);

			if (totalDays < 1) totalDays = 1;

            var dailyPrice = Vehicle?.DailyPrice > 0 ? Vehicle.DailyPrice : baseDailyPrice;
            TotalPrice = totalDays * dailyPrice;
        }

        public void UpdateStatus(DateTime referenceDate)
        {
            var date = referenceDate.Date;

            if (date >= EndDate.Date)
            {
                Status = ReservationStatus.Completed;
                return;
            }

            if (date >= StartDate.Date)
            {
                Status = ReservationStatus.Active;
                return;
            }

            Status = ReservationStatus.Reserved;
        }

        public override string ToString()
		{
			return $"Reservation ID: {Id}, Vehicle: {Vehicle}, " + $"Start: {StartDate:dd/MM/yyyy}, End: {EndDate:dd/MM/yyyy}, " + $"Total: {TotalPrice:C}, Status: {Status}";		}
	}
}
