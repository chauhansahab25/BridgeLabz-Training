using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.practice
{

    class PercentageGrade2D
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());


            int[,] marks = new int[n, 3];// 2D array to store marks
            // Columns: 0-Physics, 1-Chemistry, 2-Maths

            double[] percentage = new double[n];
            char[] grade = new char[n];


            for (int i = 0; i < n; i++)// Input marks
            {
                Console.WriteLine("Student " + (i + 1));

                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                        Console.Write("Physics marks: ");
                    else if (j == 1)
                        Console.Write("Chemistry marks: ");
                    else
                        Console.Write("Maths marks: ");

                    marks[i, j] = int.Parse(Console.ReadLine());

                    // Check for negative marks
                    if (marks[i, j] < 0)
                    {
                        Console.WriteLine("Please enter positive marks.");
                        j--; // repeat same subject
                    }
                }

                // Calculate percentage
                percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

                // Assign grade
                if (percentage[i] >= 80)
                    grade[i] = 'A';

                else if (percentage[i] >= 70)
                    grade[i] = 'B';

                else if (percentage[i] >= 60)
                    grade[i] = 'C';

                else if (percentage[i] >= 50)
                    grade[i] = 'D';

                else if (percentage[i] >= 40)
                    grade[i] = 'E';

                else
                    grade[i] = 'R';
            }


            Console.WriteLine("\n--- Student Results ---");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Student " + (i + 1) + " Physics Marks   : " + marks[i, 0] + " Chemistry Marks : " + marks[i, 1] + " Maths Marks     : " + marks[i, 2] + " Percentage : " + percentage[i] + " Grade : " + grade[i]);


            }
        }
    }

}
