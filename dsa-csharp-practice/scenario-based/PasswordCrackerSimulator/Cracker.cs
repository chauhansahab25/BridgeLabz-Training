using System;
using System.Diagnostics;

namespace CG_Practice.dsascenario.PasswordCrackerSimulator
{
    public class Cracker : ICracker
    {
        private char[] set = { 'a', 'b', 'c', '1', '2' };
        private string pass;
        private bool found;
        private Stopwatch watch = new Stopwatch();

        public Cracker(string pass)
        {
            this.pass = pass;
        }

        public void StartCrack()
        {
            if (!IsValid())
            {
                Console.WriteLine("Password contains invalid characters.");
                return;
            }

            watch.Start();
            TryAll(new char[pass.Length], 0);
            watch.Stop();

            if (!found)
                Console.WriteLine("\nPassword NOT found");

            Console.WriteLine($"Time Taken : {watch.ElapsedMilliseconds} ms");
        }

        // ✅ BACKTRACKING (CORRECT WAY)
        private void TryAll(char[] cur, int idx)
        {
            if (found) return;

            if (idx == cur.Length)
            {
                string attempt = new string(cur);
                Console.WriteLine("Trying: " + attempt);

                if (attempt == pass)
                {
                    Console.WriteLine("\nPassword Cracked ✔ : " + attempt);
                    found = true;
                }
                return;
            }

            foreach (char c in set)
            {
                cur[idx] = c;
                TryAll(cur, idx + 1);
            }
        }

        // ✅ VALIDATION
        private bool IsValid()
        {
            foreach (char c in pass)
            {
                if (Array.IndexOf(set, c) == -1)
                    return false;
            }
            return true;
        }
    }
}
