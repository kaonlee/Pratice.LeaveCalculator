using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_LeaveCalculator
{
	public class LeaveTime:WorkTime
	{

        public DateTime LeaveTimeStart { get; private set; }
		public DateTime LeaveTimeEnd { get; private set;}
        public string ErrorMessage { get; }

        public LeaveTime(string inputStart, string inputEnd)
        {
            ErrorMessage = string.Empty;
            DateTime start;
            DateTime end;

			inputStart= EnsureTwoDigitFormat(inputStart);
            inputEnd= EnsureTwoDigitFormat(inputEnd);

			bool covertStart = DateTime.TryParseExact(inputStart,"HH",CultureInfo.InvariantCulture,DateTimeStyles.None,out start);
            bool converEnd = DateTime.TryParseExact(inputEnd,"HH",CultureInfo.InvariantCulture, DateTimeStyles.None,out end);
            
            if(start>=end||end.Hour<=this.WorkStartTime.Hour||!covertStart||!converEnd)
            {
                ErrorMessage = "輸入值有誤";
            }
            else
            {
                LeaveTimeStart = ( start.Hour > this.WorkStartTime.Hour ) ? start : WorkStartTime;
                LeaveTimeEnd = ( end.Hour < this.WorkEndTime.Hour ) ? end : WorkEndTime;
			}
        }
 
        /// <summary>
        /// 計算休假時間的總時間
        /// </summary>
        /// <returns></returns>
		public int CalculateLeaveHours()
        {
            if (this.LeaveTimeEnd.Hour <= BreakStartTime.Hour || this.LeaveTimeStart.Hour >= BreekEndTime.Hour)
            {
                return this.LeaveTimeEnd.Hour - this.LeaveTimeStart.Hour;
            }
            else
            {
                return this.LeaveTimeEnd.Hour - this.LeaveTimeStart.Hour - (this.BreekEndTime.Hour-this.BreakStartTime.Hour);
            }
        }
        private string EnsureTwoDigitFormat(string input )
        {
            int length = input.Length;
            if( length == 1)
            {
                input = "0" + input;
                return input;
            }
            else
            {
                return input;
            }
        }
    }
}
