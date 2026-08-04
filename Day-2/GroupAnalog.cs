// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter number of strings: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         string[] words = new string[n];

//         Console.WriteLine("Enter the strings:");
//         for (int i = 0; i < n; i++)
//         {
//             words[i] = Console.ReadLine();
//         }

//         // Dictionary to store grouped anagrams
//         // Key = Sorted word
//         // Value = List of original words
//         Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
//         foreach (string word in words)//check each word
//         {
//             char[] ch = word.ToCharArray();//Conv word into char arr


//             // Sort the characters
//             Array.Sort(ch);

//             string key = new string(ch);//sort char back to string
//             if (!dict.ContainsKey(key))
//             {
//                 dict[key] = new List<string>();
//             }
//             dict[key].Add(word);//Add orig word to its anagram group 
//         }
//         Console.WriteLine("\nGrouped Anagrams:");

//         foreach (var group in dict.Values)
//         {
//             Console.Write("[ ");

//             foreach (string item in group)
//             {
//                 Console.Write(item + " ");
//             }
//             Console.WriteLine("]");
//         }
//     }
// }