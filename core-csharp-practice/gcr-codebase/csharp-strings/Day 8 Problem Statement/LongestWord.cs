using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Strings
{
    public class LongestWord
    {
        static string FindLongestWord(string sentence)
        {

            string longestWord = "";
            string currentWord = "";

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    currentWord += sentence[i];
                }
                else
                {
                    if (currentWord.Length > longestWord.Length)
                    {
                        longestWord = currentWord;
                    }
                    currentWord = "";
                }
            }

            if (currentWord.Length > longestWord.Length)
            {
                longestWord = currentWord;
            }

            return longestWord;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            Console.WriteLine("Longest word: " + FindLongestWord(sentence));
        }
    }
}
