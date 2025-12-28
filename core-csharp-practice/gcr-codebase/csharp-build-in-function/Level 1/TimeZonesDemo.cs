using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Build_In_Function
{
    class TimeZonesDemo
    {
        static void Main()
        {
            
            DateTimeOffset utctime = DateTimeOffset.UtcNow;
            TimeZoneInfo gmtzone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            TimeZoneInfo istzone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            TimeZoneInfo pstzone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            DateTimeOffset gmttime = TimeZoneInfo.ConvertTime(utctime, gmtzone);
            DateTimeOffset isttime = TimeZoneInfo.ConvertTime(utctime, istzone);
            DateTimeOffset psttime = TimeZoneInfo.ConvertTime(utctime, pstzone);
            Console.WriteLine("Current Time in Different Time Zones:");
            Console.WriteLine("GMT : " + gmttime);
            Console.WriteLine("IST : " + isttime);
            Console.WriteLine("PST : " + psttime);
        }
    }
}
