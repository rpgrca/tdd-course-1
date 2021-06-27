using System;
using System.Collections.Generic;

namespace Holiday
{
    public class HolidayCalendar
    {
        private readonly List<DayOfWeek> _holidayDay = new List<DayOfWeek>();

        public HolidayCalendar()
        {
        }

        public bool IsHoliday(DateTime anyDay)
        {
            return _holidayDay.Contains(anyDay.DayOfWeek);
        }

        public void MarkWeekdayAsHoliday(DayOfWeek anyDay)
        {
            _holidayDay.Add(anyDay);
        }
    }
}