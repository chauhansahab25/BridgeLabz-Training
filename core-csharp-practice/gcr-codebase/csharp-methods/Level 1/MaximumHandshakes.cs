using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    public class MaximumHandshakes
    {
        public static void Main(string[] args)
        {
            //inout no. of students
            Console.Write("Enter number of students: ");

            int students = Convert.ToInt32(Console.ReadLine());

            int HandShakes = CalculateHandshakes(students);
        }

        //Maximum Handshakes = (n × (n − 1)) / 2
        static int CalculateHandshakes(int s)
        {

            return (s * (s - 1)) / 2;


        }
    }
}
