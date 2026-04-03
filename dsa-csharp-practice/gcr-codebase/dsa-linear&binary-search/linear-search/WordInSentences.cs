using System;

namespace CG_Practice.dsacsharp.linearsearch
{
    class WordInSentences
    {
        static void Main()
        {
            string[] sentences = {
                "I love programming",
                "The weather is nice today",
                "Programming is fun and challenging",
                "Let's go for a walk"
            };
            
            string wordToFind = "programming";
            
            Console.WriteLine("Sentences:");
            for (int i = 0; i < sentences.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + sentences[i]);
            }
            Console.WriteLine();
            
            Console.WriteLine("Searching for word: " + wordToFind);
            
            string result = FindSentenceWithWord(sentences, wordToFind);
            
            if (result != null)
            {
                Console.WriteLine("Found in: " + result);
            }
            else
            {
                Console.WriteLine("Word not found in any sentence");
            }
            
            Console.ReadKey();
        }
        
        static string FindSentenceWithWord(string[] sentences, string word)
        {
            for (int i = 0; i < sentences.Length; i++)
            {
                // convert to lowercase for case-insensitive search
                if (sentences[i].ToLower().Contains(word.ToLower()))
                {
                    return sentences[i];
                }
            }
            return null; // not found
        }
    }
}