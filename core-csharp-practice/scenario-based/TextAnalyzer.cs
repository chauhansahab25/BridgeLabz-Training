//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CG_Practice.scenariobased
//{
//          public class TextAnalyzer
//        {
//            public static int WordsCount(String str)
//            {
//                int count = 0;
//                for (int i = 1; i < str.Length - 1; i++)
//                {
//                    if ((str[i] == ' ' && str[i - 1] != ' ') && (str[i] == ' ' && str[i + 1] != ' '))
//                    {
//                        count++;
//                    }
//                }
//                return count + 1;
//            }

//            public static String LongestWord(String str)
//            {
//                StringBuilder temp = new StringBuilder();
//                StringBuilder lng = new StringBuilder();

//                int longLength = 0;

//                for (int i = 0; i < str.Length; i++)
//                {
//                    if (str[i] == ' ' || str[i] == ',' || str[i] == ';')
//                    {
//                        if (temp.Length >= lng.Length)
//                        {
//                            lng.Clear();
//                            lng.Append(temp);
//                        }
//                        temp.Clear();
//                    }

//                    else
//                    {
//                        temp.Append(str[i]);
//                    }


//                }
//                return lng.ToString();
//            }

//            public static String WordReplace(String str, String word, String change)
//            {
//                StringBuilder temp = new StringBuilder();
//                StringBuilder result = new StringBuilder();

//                for (int i = 0; i < str.Length; i++)
//                {
//                    if (str[i] == ' ' || str[i] == '.' || str[i] == ';' || str[i] == '?' || str[i] == ',' || str[i] == '}' || str[i] == ']' || str[i] == '-' || str[i] == ')')
//                    {
//                        if (word == temp.ToString())
//                        {

//                            result.Append(change);
//                            result.Append(str[i]);
//                            temp.Clear();
//                        }
//                        else
//                        {

//                            result.Append(temp);
//                            result.Append(str[i]);
//                            temp.Clear();
//                        }
//                    }

//                    else
//                    {
//                        temp.Append(str[i]);
//                    }

//                }
//                return result.ToString();
//            }

//            public static void DisplayMenu()
//            {
//                Console.WriteLine("------------------------------------------");
//                Console.WriteLine("      Welcome to the Text Analyzer        ");
//                Console.WriteLine("------------------------------------------");

//                Console.Write("Enter the text to analyze: ");
//                String str = Console.ReadLine();

//                bool exit = false;

//                while (!exit)
//                {
//                    Console.WriteLine("\n------------------------------------------");
//                    Console.WriteLine($"CURRENT STRING: \"{str}\"");
//                    Console.WriteLine("------------------------------------------");
//                    Console.WriteLine("1. Count Total Words");
//                    Console.WriteLine("2. Find the Longest Word");
//                    Console.WriteLine("3. Find and Replace amy Word");
//                    Console.WriteLine("4. Enter New Text");
//                    Console.WriteLine("5. Exit");
//                    Console.WriteLine("------------------------------------------");
//                    Console.Write("Select an option (1-5): ");

//                    String choice = Console.ReadLine();

//                    switch (choice)
//                    {
//                        case "1":
//                            int count = WordsCount(str);
//                            Console.WriteLine($"\n[Result] Total Words: {count}");
//                            break;

//                        case "2":
//                            String longest = LongestWord(str);
//                            Console.WriteLine($"\n[Result] Longest Word: \"{longest}\"");
//                            break;

//                        case "3":
//                            Console.Write("\nEnter the word to find: ");
//                            String find = Console.ReadLine();

//                            Console.Write("Enter the word to replace it with: ");
//                            String replace = Console.ReadLine();

//                            String replacedString = WordReplace(str, find, replace);
//                            Console.WriteLine($"\n[Result] Updated String: \"{replacedString}\"");

//                            // Optional: Update the current string to the new version?
//                            // Uncomment the line below if you want the change to be permanent for the session
//                            // str = replacedString; 
//                            break;

//                        case "4":
//                            Console.Write("\nEnter new string: ");
//                            str = Console.ReadLine();
//                            Console.WriteLine("String updated.");
//                            break;

//                        case "5":
//                            exit = true;
//                            Console.WriteLine("Exiting... Goodbye!");
//                            break;

//                        default:
//                            Console.WriteLine("Invalid choice! Please try again.");
//                            break;
//                    }
//                }
//            }

//            public static void Main(String[] args)
//            {
//                DisplayMenu();

//            }
//        }
// }