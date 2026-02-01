using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRentalSystem
{
    public static class AppClock
    {
        private static DateTime _currentDate = DateTime.Today;

        public static event Action<DateTime> DateChanged;

        public static DateTime Today => _currentDate.Date;

        public static void SetDate(DateTime date)
        {
            var normalized = date.Date;
            if (normalized == _currentDate.Date)
            {
                return;
            }

            _currentDate = normalized;
            DateChanged?.Invoke(_currentDate);
        }

        public static void AdvanceDays(int days)
        {
            SetDate(_currentDate.AddDays(days));
        }
    }
}
