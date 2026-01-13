using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.dsascenario.CinemaTimeManager
{
    public class Movie
    {
        public string Title { get; set; }
        public string ShowTime { get; set; }

        public Movie(string title, string showTime)
        {
            Title = title;
            ShowTime = showTime;
        }

        public override string ToString()
        {
            return Title + " - " + ShowTime;
        }
    }
}
