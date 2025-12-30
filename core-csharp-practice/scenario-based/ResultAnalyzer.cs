using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CG_Practice.scenariobased
{ 
        class ResultAnalyzer
        {
            static void ResultMenu(double[] marks)
            {
                while (true)
                {
                    Console.WriteLine("SELECT AN OPTION");
                    Console.WriteLine("1. CALCULATE WHOLE CLASS AVERAGE");
                    Console.WriteLine("2. DISPLAY HIGHEST AND LOWEST MARKS");
                    Console.WriteLine("3. SHOW STUDENTS SCORING ABOVE AVERAGE");
                    Console.WriteLine("4. VALIDATE INVALID MARKS");
                    Console.WriteLine("5. EXIT PROGRAM");

                    int options = int.Parse(Console.ReadLine());

                    switch (options)
                    {
                        case 1:
                            Console.WriteLine("Average of the class is " + CalculateAverage(marks));
                            break;

                        case 2:
                            FindMaxAndMin(marks);
                            break;

                        case 3:
                            ShowAboveAverage(marks);
                            break;

                        case 4:
                            CheckInvalidMarks(marks);
                            break;

                        case 5:
                            return;

                        default:
                            Console.WriteLine("INVALID OPERATION");
                            break;
                    }
                }
            }

            public static double CalculateAverage(double[] marks)
            {
                double total = 0.0;
                for (int i = 0; i < marks.Length; i++)
                {
                    total += marks[i];
                }
                return total / marks.Length;
            }

            public static void FindMaxAndMin(double[] marks)
            {
                double max = 0.0;
                double min = double.MaxValue;

                for (int i = 0; i < marks.Length; i++)
                {
                    if (marks[i] > max) max = marks[i];
                    if (marks[i] < min) min = marks[i];
                }

                Console.WriteLine("Higest score is " + max + " Lowest Score is " + min);
            }

            public static void ShowAboveAverage(double[] marks)
            {
                double avg = CalculateAverage(marks);

                for (int i = 0; i < marks.Length; i++)
                {
                    if (marks[i] > avg)
                    {
                        Console.WriteLine(
                            "The student " + (i + 1) +
                            " got his score " + marks[i] +
                            " is higher than average (" + avg + ")"
                        );
                    }
                }
            }

            static void CheckInvalidMarks(double[] marks)
            {
                int limit = 0;

                for (int i = 0; i < marks.Length; i++)
                {
                    if (!(marks[i] >= limit))
                    {
                        Console.WriteLine(
                            "You input invalid marks of this student " +
                            (i + 1) +
                            " Input marks greater than or equal to 0"
                        );
                    }
                }
            }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students:");
            int count;

            while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.WriteLine("enter a valid positive number of students:");
            }

            double[] marks = new double[count];

            Console.WriteLine("Enter the test scores of students :");

            for (int i = 0; i < count; i++)
            {
                while (!double.TryParse(Console.ReadLine(), out marks[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a number:");
                }
            }

            ResultMenu(marks);
        }

    }
}

