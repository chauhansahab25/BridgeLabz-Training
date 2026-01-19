// using System;
// using System.Collections.Generic;
// using CG_Practice.dsascenario.DynamicOnlineMarketplace.Categories;
// using CG_Practice.dsascenario.DynamicOnlineMarketplace.Models;
// using CG_Practice.dsascenario.DynamicOnlineMarketplace.Utilities;

// namespace CG_Practice.dsascenario.DynamicOnlineMarketplace.Menu
// {
//     public class MarketplaceMenu
//     {
//         private readonly List<Product> products = new List<Product>();

//         public void ShowMenu()
//         {
//             BookCategory bookCategory = new BookCategory();
//             ClothingCategory clothingCategory = new ClothingCategory();

//             Product<BookCategory> book =
//                 new Product<BookCategory>("C# in Depth", 800, bookCategory);

//             Product<ClothingCategory> shirt =
//                 new Product<ClothingCategory>("Cotton Shirt", 1500, clothingCategory);

//             DiscountUtility.ApplyDiscount(book, 10);
//             DiscountUtility.ApplyDiscount(shirt, 20);

//             products.Add(book);
//             products.Add(shirt);

//             Console.WriteLine("----- PRODUCT CATALOG -----");
//             foreach (var product in products)
//             {
//                 product.Display();
//             }
//         }
//     }
// }
