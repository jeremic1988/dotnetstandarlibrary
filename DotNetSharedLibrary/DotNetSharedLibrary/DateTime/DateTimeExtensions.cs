using System;
namespace DotNetSharedLibrary.DateTime
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Method returns new timespan object
        /// </summary>
        /// <param name="minutes">
        /// Represents minutes which will be added to the timespan object</param>
        /// <returns></returns>
        public static TimeSpan AddMinutes(this TimeSpan time, int minutes)
        {
            return time.Add(new TimeSpan(0, minutes, 0));
        }

        /// <summary>
        /// Returns string object representations by specified format
        /// </summary>
        /// <param name="timeSpan"></param>
        /// <param name="format">
        /// String that defines format which will be used for processing timespan object
        /// </param>
        /// <returns></returns>
        public static string ToCustomTimeSpanFormat(this object timeSpan, string format)
        {
            if (timeSpan == null)
            {
                throw new ArgumentException("timeSpan");
            }

            TimeSpan time = TimeSpan.Parse(timeSpan.ToString());
            return time.ToString(format);
        }
    }
}
