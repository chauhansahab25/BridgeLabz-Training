using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Practice.scenariobased
{
        public class TextEditor
        {
            public static String AddSpacingAfterPunctuation(String text)
            {
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == ',' || text[i] == ':' || text[i] == ';' || text[i] == '?' || text[i] == '.' || text[i] == '!')
                    {
                        builder.Append(text[i]);
                        builder.Append(" ");
                    }
                    else
                    {
                        builder.Append(text[i]);
                    }
                }

                return builder.ToString();
            }

            public static String FixCapitalization(String text)
            {
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < text.Length; i++)
                {
                    if (i < text.Length - 2)
                    {
                        if (text[i] == '.' || text[i] == '?' || text[i] == '!')
                        {
                            builder.Append(text[i]);
                            builder.Append(text[i + 1]);
                            builder.Append(char.ToUpper(text[i + 2]));
                            i = i + 2;
                        }
                        else
                        {
                            builder.Append(text[i]);
                        }
                    }
                    else
                    {
                        builder.Append(text[i]);
                    }
                }

                return builder.ToString();
            }

            public static String RemoveDoubleSpaces(String text)
            {
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < text.Length; i++)
                {
                    if (i < text.Length - 1)
                    {
                        if (text[i] == ' ' && text[i + 1] == ' ')
                        {

                        }
                        else
                        {
                            builder.Append(text[i]);
                        }
                    }
                    else
                    {
                        builder.Append(text[i]);
                    }
                }

                return builder.ToString();
            }

            public static void RunInterface()
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("           Text Editor Tool               ");
                Console.WriteLine("------------------------------------------");

                Console.Write("Please enter text: ");
                String userInput = Console.ReadLine();

                bool keepRunning = true;

                while (keepRunning)
                {
                    Console.WriteLine("\n------------------------------------------");
                    Console.WriteLine($"CURRENT TEXT: {userInput}");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("1. Add Space After Punctuation");
                    Console.WriteLine("2. Capitalize Sentences");
                    Console.WriteLine("3. Remove Extra Spaces");
                    Console.WriteLine("4. Apply All Changes");
                    Console.WriteLine("5. Reset Text");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("------------------------------------------");
                    Console.Write("Select an option (1-6): ");

                    String selection = Console.ReadLine();

                    switch (selection)
                    {
                        case "1":
                            userInput = AddSpacingAfterPunctuation(userInput);
                            Console.WriteLine(" > Punctuation spacing updated.");
                            break;
                        case "2":
                            userInput = FixCapitalization(userInput);
                            Console.WriteLine(" > Capitalization updated.");
                            break;
                        case "3":
                            userInput = RemoveDoubleSpaces(userInput);
                            Console.WriteLine(" > Double spaces removed.");
                            break;
                        case "4":
                            userInput = AddSpacingAfterPunctuation(userInput);
                            userInput = FixCapitalization(userInput);
                            userInput = RemoveDoubleSpaces(userInput);
                            Console.WriteLine(" > All formatting applied.");
                            break;
                        case "5":
                            Console.Write("Enter new text: ");
                            userInput = Console.ReadLine();
                            break;
                        case "6":
                            keepRunning = false;
                            Console.WriteLine("Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Try again.");
                            break;
                    }
                }
            }

            public static void Main(String[] args)
            {
                RunInterface();
            }
        }
}

