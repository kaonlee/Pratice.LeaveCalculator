using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_LeaveCalculator
{
    public class WorkTime
    {
        public DateTime WorkStartTime { get; private set; }
        public DateTime BreakStartTime { get; private set; }
        public DateTime BreekEndTime { get; private set; }
        public DateTime WorkEndTime { get; private set; }

        public WorkTime()
        {
            DateTime today = DateTime.Today;
			this.WorkStartTime = new DateTime(today.Year, today.Month, today.Day, 9, 0, 0);
			this.BreakStartTime = new DateTime(today.Year,today.Month,today.Day,12,0,0);
            this.BreekEndTime = new DateTime(today.Year, today.Month, today.Day, 13, 0, 0);
			this.WorkEndTime = new DateTime(today.Year, today.Month, today.Day, 18, 0, 0);
		}

    }
}
