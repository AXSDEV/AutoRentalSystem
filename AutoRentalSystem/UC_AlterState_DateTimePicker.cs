using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRentalSystem
{
    public partial class UC_AlterState_DateTimePicker : UserControl
    {
        public UC_AlterState_DateTimePicker()
        {
            InitializeComponent();
            dateTimePicker_startDate.Value = AppClock.Today;
            dateTimePicker_endDate.Value = AppClock.Today.AddDays(1);
            dateTimePicker_startDate.ValueChanged += (_, __) =>
            {
                if (dateTimePicker_endDate.Value.Date < dateTimePicker_startDate.Value.Date)
                {
                    dateTimePicker_endDate.Value = dateTimePicker_startDate.Value.Date;
                }
            };
        }

        public DateTime MaintenanceStartDate
        {
            get => dateTimePicker_startDate.Value.Date;
            set => dateTimePicker_startDate.Value = value.Date;
        }

        public DateTime MaintenanceEndDate
        {
            get => dateTimePicker_endDate.Value.Date;
            set => dateTimePicker_endDate.Value = value.Date;
        }
    }
}
