using System;

class Samavgmarks
{
    static void Main()
    {
        int mathmarks = 94; 
        int physicsmarks = 95;
        int chemistrymarks = 96;
        int avg = (mathmarks + physicsmarks + chemistrymarks)/3;

        Console.WriteLine("Average percentage marks in PCM: " + avg);
    }
}