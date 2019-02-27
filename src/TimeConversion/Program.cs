using System;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string strTime = Convert.ToString(Console.ReadLine()); //07:05:45PM
            string[] timeSplitted = strTime.Split(':');
            int hour, min, sec;
            hour = Convert.ToInt32(timeSplitted[0]);
            min = Convert.ToInt32(timeSplitted[1]);
            sec = Convert.ToInt32(timeSplitted[2].Substring(0, 2));
            string tt = timeSplitted[2].Substring(2, 2);
            if(tt.ToLower().Trim().Equals("pm"))
            {
                hour += 12;
            }

            string outputTime = $"{hour.ToString("00")}:{min.ToString("00")}:{sec.ToString("00")}";
            Console.WriteLine(outputTime);
            Console.Read();
        }
    }
}
