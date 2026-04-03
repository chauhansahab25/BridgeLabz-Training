using System;
uusing System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    public class StudentVoteChecker
    {
        // check whether a student can vote
        public static bool CanStudentVote(int age)
        {
            // Validate negative age
            if (age < 0)
            {
                return false;
            }

            // Check voting eligibility
            if (age >= 18)
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            int[] ages = new int[10];

            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write("Enter age of student " + (i + 1) + ": ");
                ages[i] = Convert.ToInt32(Console.ReadLine());

                bool canVote = CanStudentVote(ages[i]);

                if (canVote)
                {
                    Console.WriteLine("Student " + (i + 1) + " is eligible to vote.");
                }
                else
                {
                    Console.WriteLine("Student " + (i + 1) + " is NOT eligible to vote.");
                }
            }
        }
    }
}
