using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.dsascenario.CinemaTimeManager
{
    public class TimeUtility
    {
        // validate time format (HH:MM AM/PM)
        public static bool ValidateTimeFormat(string time)
        {
            if (time.Length < 7 || time.Length > 8)
            {
                return false;
            }

            string[] parts = time.Split(' ');
            if (parts.Length != 2)
            {
                return false;
            }

            string timePart = parts[0];
            string ampm = parts[1].ToUpper();

            if (ampm != "AM" && ampm != "PM")
            {
                return false;
            }

            if (timePart.Length != 5 || timePart[2] != ':')
            {
                return false;
            }

            string[] timeComponents = timePart.Split(':');
            int hours = int.Parse(timeComponents[0]);
            int minutes = int.Parse(timeComponents[1]);

            if (hours < 1 || hours > 12 || minutes < 0 || minutes > 59)
            {
                return false;
            }

            return true;
        }

        // format movie display info
        public static string FormatMovieInfo(Movie movie, int index)
        {
            return (index + 1) + ". " + movie.ToString();
        }
    }
}
