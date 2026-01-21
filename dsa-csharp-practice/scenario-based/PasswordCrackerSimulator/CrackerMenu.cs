using System;

namespace CG_Practice.dsascenario.PasswordCrackerSimulator
{
    public class CrackerMenu
    {
        public static void Start()
        {
            Console.Write("Enter password (only a,b,c,1,2): ");
            string pass = Console.ReadLine();

            Cracker crack = new Cracker(pass);
            crack.StartCrack();

            CrackerUtility.ShowComplexity(pass.Length, 5);
        }
    }
}
