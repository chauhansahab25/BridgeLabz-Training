using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.practice
{
    public class BMIofPerson
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number of person");
            int p = Convert.ToInt32(Console.ReadLine());

            double[] weight = new double[p];
            double[] height = new double[p];
            double[] bmi = new double[p];
            string[] status = new string[p];

            Console.WriteLine("Enter weight and hieght of Person");
            for (int i = 0; i < p; i++)
            {

                Console.WriteLine("Enter weight ");
                weight[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter height ");
                height[i] = Convert.ToDouble(Console.ReadLine() / 100);

            }

            //BMI status
            for (int i = 0; i < p; i++)
            {
                bmi[i] = weight[i] / (height[i] * height[i]);

                if (bmi[i] < 18.5)
                    status[i] = "Underweight";

                else if (bmi[i] < 25)
                    status[i] = "Normal";

                else if (bmi[i] < 30)
                    status[i] = "Overweight";

                else
                    status[i] = "Obese";
            }

            for (int i = 0; i < p; i++)
            {
                Console.WriteLine("\nPerson " + (i + 1));

                Console.WriteLine("Height : " + height[i] + " m");

                Console.WriteLine("Weight : " + weight[i] + " kg");

                Console.WriteLine("BMI    : " + bmi[i].ToString("F2"));

                Console.WriteLine("Status : " + status[i]);
            }



        }
    }
}
}
