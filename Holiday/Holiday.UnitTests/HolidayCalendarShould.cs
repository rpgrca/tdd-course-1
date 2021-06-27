using Holiday;
using System;
using Xunit;

namespace Holiday.UnitTests
{
    public class HolidayCalendarShould
    {
        [Fact]
        public void Test1()
        {
            var holidayCalendar = new HolidayCalendar();
            var anySunday = new DateTime(2020, 4, 19);
            holidayCalendar.MarkWeekdayAsHoliday(DayOfWeek.Sunday);
            Assert.True(holidayCalendar.IsHoliday(anySunday));
        }

        [Fact]
        public void Test2()
        {
            var holidayCalendar = new HolidayCalendar();
            var anyMonday = new DateTime(2020, 4, 20);
            Assert.False(holidayCalendar.IsHoliday(anyMonday));
        }

        [Fact]
        public void Test3()
        {
            var holidayCalendar = new HolidayCalendar();
            var anySaturday = new DateTime(2020, 4, 18);
            holidayCalendar.MarkWeekdayAsHoliday(DayOfWeek.Saturday);
            Assert.True(holidayCalendar.IsHoliday(anySaturday));
        }

        [Fact]
        public void Test4()
        {
            var holidayCalendar = new HolidayCalendar();
            var anySaturday = new DateTime(2020, 4, 18);
            var anySunday = new DateTime(2020, 4, 19);
            holidayCalendar.MarkWeekdayAsHoliday(DayOfWeek.Saturday);
            holidayCalendar.MarkWeekdayAsHoliday(DayOfWeek.Sunday);
            Assert.True(holidayCalendar.IsHoliday(anySaturday));
            Assert.True(holidayCalendar.IsHoliday(anySunday));
        }
    }
}
