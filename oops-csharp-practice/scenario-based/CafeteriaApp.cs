using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopsscenario
{
        class CafeteriaApp
        {
            // Stores available food items
            static string[] foodList =
            {
            "Veg Roll",
            "Cheese Sandwich",
            "Paneer Burger",
            "Veg Pizza",
            "White Sauce Pasta",
            "Veg Fried Rice",
            "Hakka Noodles",
            "Cold Coffee",
            "Lemon Juice",
            "Chocolate Ice Cream"
        };

            static void Main(string[] args)
            {
                Console.WriteLine("=== Campus Cafeteria Menu ===\n");

                // Show all food items
                ShowFoodMenu();

                Console.Write("\nEnter item number to order: ");
                int userChoice = Convert.ToInt32(Console.ReadLine());

                // Fetch selected item
                string orderedFood = FetchFoodItem(userChoice);

                if (orderedFood != null)
                {
                    Console.WriteLine("\nOrder Confirmed: " + orderedFood);
                }
                else
                {
                    Console.WriteLine("\nInvalid item number. Please try again.");
                }
            }

            // Displays menu with item numbers
            static void ShowFoodMenu()
            {
                for (int position = 0; position < foodList.Length; position++)
                {
                    Console.WriteLine(position + " -> " + foodList[position]);
                }
            }

            // Returns food item based on index
            static string FetchFoodItem(int position)
            {
                if (position >= 0 && position < foodList.Length)
                {
                    return foodList[position];
                }
                return null;
            }
        }
    
}
