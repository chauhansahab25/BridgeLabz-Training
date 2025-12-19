using System;

class Penperstudent
{
    static void Main()
    {
        int totalpen = 14; 
        int students = 3;
        int rem =  totalpen % students;
        int pps = totalpen / students;

        Console.WriteLine("The pen per student is " + pps + "and the remaining pen not distributed is " + rem);
    }
}