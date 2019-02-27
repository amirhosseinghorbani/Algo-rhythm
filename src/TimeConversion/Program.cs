using System;

namespace TimeConversion
{
    //problem url: https://www.hackerrank.com/challenges/time-conversion
    public class Program
    {
        public const string AM = "am";
        public const string PM = "pm";

        static void Main(string[] args)
        {
            string strTime = Convert.ToString(Console.ReadLine()); //07:05:45PM
            string result = format24Time(strTime);
            Console.WriteLine(result);

            Console.Read();
        }

        static string format24Time(string time)
        {
            string[] timeSplitted = time.Split(':');
            int hour, min, sec;
            hour = Convert.ToInt32(timeSplitted[0]);
            min = Convert.ToInt32(timeSplitted[1]);
            sec = Convert.ToInt32(timeSplitted[2].Substring(0, 2));
            string tt = timeSplitted[2].Substring(2, 2);
            if (tt.comparbleTimeString().Equals(PM) && hour < 12)
                hour += 12;
            if (tt.comparbleTimeString().Equals(PM) && hour >= 24)
                hour -= 24;
            if (tt.comparbleTimeString().Equals(AM) && hour.Equals(12))
                hour -= 12;

            string outputTime = $"{hour.ToString("00")}:{min.ToString("00")}:{sec.ToString("00")}";
            return outputTime;
        }
    }

    public static class StringExtension
    {
        public static string comparbleTimeString(this string time) => time.ToLower().Trim();
    }
}
