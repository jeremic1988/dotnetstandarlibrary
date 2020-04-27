using Xunit;
using System;
using DotNetSharedLibrary.DateTime;
namespace DemoApp.Tests
{
    public class DataTimeTest
    {
        [Fact]
        public void TestAddMinutesExtension()
        {
            TimeSpan time = new TimeSpan(21, 0, 0);
            time = time.AddMinutes(2);
            
            // date time is struct dat
            Assert.True(time.Minutes == 2 && time.Hours == 21 && time.Seconds == 0);
        }

        [Fact]
        public void TestAddMinutesWithNegativeExtension()
        {
            TimeSpan time = new TimeSpan(21, 0, 0);
            time = time.AddMinutes(-2);

            // date time is struct dat
            Assert.True(time.Minutes == 58 && time.Hours == 20 && time.Seconds == 0);
        }

        [Fact]
        public void TestToCustomTimeSpanFormatMethod()
        {
            string format = @"hh\:mm";
            TimeSpan time = new TimeSpan(21, 0, 0);

            string timeAsString = time.ToCustomTimeSpanFormat(format);
            
            // try to get the same timespan from string
            TimeSpan time2 = TimeSpan.ParseExact(timeAsString, format, 
                System.Globalization.CultureInfo.CurrentCulture);

            Assert.True(time == time2);
        }
    }
}
