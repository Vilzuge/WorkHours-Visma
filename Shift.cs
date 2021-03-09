//Ville Martas
//09.03.2020

using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationVisma
{
    public class Shift
    {
        private DateTime date;
        private string start, end;
        private decimal hourStart, hourEnd, hours;
        private decimal minuteStart, minuteEnd, minutes;
        private decimal total;

        public Shift(DateTime aDate, string aStart, string aEnd)
        {
            date = aDate;
            start = aStart;
            end = aEnd;

            string[] startTimes = start.Split(':');
            string[] endTimes = end.Split(':');

            hourStart = decimal.Parse(startTimes[0]);
            hourEnd = decimal.Parse(endTimes[0]);
            if (hourStart < 0 || hourStart > 23 || hourEnd < 0 || hourEnd > 23)
                throw new ArgumentException("Individual hours out of bounds. Possible values for hours are 00-23.");

            minuteStart = decimal.Parse(startTimes[1]);
            minuteEnd = decimal.Parse(endTimes[1]);
            if (minuteStart < 0 || minuteStart > 59 || minuteEnd < 0 || minuteEnd > 59)
                throw new ArgumentException("Individual minutes out of bounds. Possible values for minutes are 00-59");

            hours = hourEnd - hourStart;
            minutes = (minuteEnd - minuteStart) / 60; //can be negative!

            if (hours < 0)
                throw new ArgumentException("Hours can not be negative. Shift must start before it ends.");

            total = hours + minutes;
            if (total < 0 || total > 16)
                throw new ArgumentException("Shifts length minimum is 0 and maximum 16 hours.");
        }

        public decimal DayLength
        {
            get { return total; }
        }
    }
}
