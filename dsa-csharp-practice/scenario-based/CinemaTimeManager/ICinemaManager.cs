using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.dsascenario.CinemaTimeManager
{
    public interface ICinemaManager
    {
        void AddMovie(string title, string time);
        void SearchMovie(string keyword);
        void DisplayAllMovies();
        void GenerateReport();
    }
}
