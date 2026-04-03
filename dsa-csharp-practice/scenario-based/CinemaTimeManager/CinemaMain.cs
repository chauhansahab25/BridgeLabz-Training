using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.dsascenario.CinemaTimeManager
{
    class CinemaMain
    {
        static void Main()
        {
            Console.WriteLine("CinemaTime - Movie Schedule Manager");
            Console.WriteLine();

            ICinemaManager cinema = new CinemaManagerImpl(10);

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Search Movie");
                Console.WriteLine("3. Display All Movies");
                Console.WriteLine("4. Generate Report");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter movie title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter show time (HH:MM AM/PM): ");
                        string time = Console.ReadLine();
                        cinema.AddMovie(title, time);
                        break;

                    case 2:
                        Console.Write("Enter search keyword: ");
                        string keyword = Console.ReadLine();
                        cinema.SearchMovie(keyword);
                        break;

                    case 3:
                        cinema.DisplayAllMovies();
                        break;

                    case 4:
                        cinema.GenerateReport();
                        break;

                    case 5:
                        Console.WriteLine("Thank you for using CinemaTime!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.WriteLine();
            }
        }
    }
}


