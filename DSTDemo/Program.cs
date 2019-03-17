using System;

namespace DSTDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo sydneyTimezone = TimeZoneInfo.FindSystemTimeZoneById("AUS Eastern Standard Time");
            DateTime sydneyTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, sydneyTimezone);

           // Console.WriteLine(sydneyTime);


            DateTime newDate = new DateTime(2010, 1, 1,  5, 59, 59);
            var date = DateTime.SpecifyKind(newDate, DateTimeKind.Utc);


            Console.WriteLine(TimeZoneInfo.ConvertTime(date, sydneyTimezone));

            Console.ReadLine();
        }
    }
}
