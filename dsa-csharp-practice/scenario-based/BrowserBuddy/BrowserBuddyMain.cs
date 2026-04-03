using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.dsascenario.BookBuddy
{
    class BrowserBuddyMain
    {
        static void Main(string[] args)
        {
            ITaskHistoryManagerOperations browser = new BrowserFunctionImpl();
            BrowserFunctionsMenu.DisplayMenu(browser);
        }
    }
}
