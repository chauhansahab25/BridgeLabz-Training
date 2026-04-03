//using System;

//class VotingAge
//{
//    static void Main()
//    {
//        int[] ages = new int[10];

//        Console.WriteLine("Enter ages of 10 Students:");
//        for (int i = 0; i < ages.Length; i++)
//        {
//            Console.Write("Student " + (i + 1) + ": ");
//            ages[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        for (int i = 0; i < ages.Length; i++)
//        {
//            if (ages[i] < 0)
//            {
//                Console.WriteLine("Invalid Age");
//            }
//            else if (ages[i] >= 18)
//            {
//                Console.WriteLine("The Student with age " + ages[i] + " can vote.");
//            }
//            else
//            {
//                Console.WriteLine("The Student with age " + ages[i] + " cannot vote.");
//            }
//        }
//    }
//}
