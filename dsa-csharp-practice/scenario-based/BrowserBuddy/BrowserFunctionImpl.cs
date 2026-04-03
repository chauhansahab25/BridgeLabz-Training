using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.dsascenario.BookBuddy
{
    class BrowserFunctionImpl:ITaskHistoryManagerOperations
    {
        private BrowserTab currentTab;
        private BrowserTab head;
        private Stack<BrowserTab> closedTabs = new Stack<BrowserTab>();

       public void VisitPage(string url) 
       {
            BrowserTab newTab = new BrowserTab(url);
            if (head == null)
            {
                head = currentTab = newTab;
            }
            else 
            {
                currentTab.Next=newTab;
                newTab.Previous = currentTab;
                currentTab=newTab;
            }
            Console.WriteLine("Visited"+ url);
       }
       public void GoBack() 
        {
            if (currentTab != null && currentTab.Previous != null) 
            {
                currentTab = currentTab.Previous;
                Console.WriteLine("Back to previous url" +currentTab.Url);
            }
            else
            {
                Console.WriteLine("No previous page.");
            }
        }
       public void GoForward() 
        {
            if (currentTab != null && currentTab.Next != null)
            {
                currentTab = currentTab.Next;
                Console.WriteLine("Back to previous url" + currentTab.Url);
            }
            else
            {
                Console.WriteLine("No next page.");
            }

        }
       public void CloseTab() 
       {
            if(currentTab != null)
            {
                closedTabs.Push(currentTab);
                Console.WriteLine("Close tab"+currentTab.Url);
                currentTab = currentTab.Previous;
            }
            else
            {
                Console.WriteLine("No tabs to close");
            }   
       }
       public void RestoreTabs() 
       {
            if(closedTabs.Count != 0)
            {
                BrowserTab restoredTab = closedTabs.Pop();
                Console.WriteLine("Restored tab:"+restoredTab.Url);
                currentTab= restoredTab;
                
            }
            else
            {
                Console.WriteLine("No tabs to close.");
            }
       }
       public void ShowHistory() 
        {
            BrowserTab temporaryTab = head;
            while (temporaryTab != null) 
            {
                if(temporaryTab== currentTab)
                {
                    Console.WriteLine("["+temporaryTab.Url+"]");
                }
                else
                {
                    Console.WriteLine(temporaryTab.Url+"");
                }
                temporaryTab = temporaryTab.Next;
            }
            Console.WriteLine();
        }
    }

}
