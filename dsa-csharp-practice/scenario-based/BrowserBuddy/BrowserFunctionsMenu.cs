using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.dsascenario.BookBuddy
{
    class BrowserFunctionsMenu
    {
        public static void DisplayMenu(ITaskHistoryManagerOperations browser)
        {
            int choice;
            do
            {
                Console.WriteLine("BrowserBuddy Menu");
                Console.WriteLine("1. Visit Page");
                Console.WriteLine("2. Go Back");
                Console.WriteLine("3. Go Forward");
                Console.WriteLine("4. Close Tab");
                Console.WriteLine("5. Restore Closed Tab");
                Console.WriteLine("6. Show History");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter URL: ");
                        browser.VisitPage(Console.ReadLine());
                        break;
                    case 2:
                        browser.GoBack();
                        break;
                    case 3:
                        browser.GoForward();
                        break;
                    case 4:
                        browser.CloseTab();
                        break;
                    case 5:
                        browser.RestoreTabs();
                        break;
                    case 6:
                        browser.ShowHistory();
                        break;
                }
            } while (choice != 0);

        }
    }
}
