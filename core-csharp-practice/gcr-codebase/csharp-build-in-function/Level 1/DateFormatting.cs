using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Build_In_Function
{
    public class DateFormatting
    {
        static void Main()
        {
            DateTime today = DateTime.Now;

            Console.WriteLine(today.ToString("dd/MM/yyyy"));
            Console.WriteLine(today.ToString("yyyy-MM-dd"));
            Console.WriteLine(today.ToString("ddd, MMM dd, yyyy"));
        }
    }
}
