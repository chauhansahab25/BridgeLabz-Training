using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.practice
{

    public class PercentageGrade
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter number of students ");
            int n = int.Parse(Console.ReadLine());

            int[] phy = new int[n];
            int[] chem = new int[n];
            int[] maths = new int[n];
            double[] per = new double[n];
            char[] grd = new char[n];

            // Input marks
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Student {i + 1}");

                Console.Write("Physics marks: ");
                phy[i] = int.Parse(Console.ReadLine());
                if (phy[i] < 0) { i--; continue; }

                Console.Write("Chemistry marks: ");
                chem[i] = int.Parse(Console.ReadLine());
                if (chem[i] < 0) { i--; continue; }

                Console.Write("Maths marks: ");
                maths[i] = int.Parse(Console.ReadLine());
                if (maths[i] < 0) { i--; continue; }

                // Calculate percentage by /3
                per[i] = (phy[i] + chem[i] + maths[i]) / 3.0;

                //  grade
                if (per[i] >= 80)
                    grd[i] = 'A';
                else if (per[i] >= 70)
                    grd[i] = 'B';
                else if (per[i] >= 60)
                    grd[i] = 'C';
                else if (per[i] >= 50)
                    grd[i] = 'D';
                else if (per[i] >= 40)
                    grd[i] = 'E';
                else
                    grd[i] = 'R';
            }


            for (int i = 0; i < n; i++) //result
            {
                Console.WriteLine($" Physics={phy[i]}, Chemistry={chem[i]}, Maths={maths[i]}, Percentage={per[i]}, Grade={grd[i]}");
            }
        }
    }

}


