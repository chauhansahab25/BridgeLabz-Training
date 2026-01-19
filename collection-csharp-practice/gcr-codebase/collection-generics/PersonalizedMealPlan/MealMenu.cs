// using System;

// namespace CG_Practice.dsascenario.PersonalizedMealPlan
// {
//     public class MealMenu
//     {
//         public static void Start()
//         {
//             Console.WriteLine("1. Vegetarian");
//             Console.WriteLine("2. Vegan");
//             Console.WriteLine("3. Keto");
//             Console.Write("Choose option: ");

//             int ch = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine();

//             switch (ch)
//             {
//                 case 1:
//                     MealUtility.ShowMeal<VegetarianMeal>();
//                     break;

//                 case 2:
//                     MealUtility.ShowMeal<VeganMeal>();
//                     break;

//                 case 3:
//                     MealUtility.ShowMeal<KetoMeal>();
//                     break;

//                 default:
//                     Console.WriteLine("Invalid choice");
//                     break;
//             }
//         }
//     }
// }
