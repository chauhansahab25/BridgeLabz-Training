using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.dsascenario.BookBuddy
{
    interface ITaskHistoryManagerOperations
    {
        void VisitPage(string url);
        void GoBack();
        void GoForward();
        void CloseTab();
        void RestoreTabs();
        void ShowHistory();

    }
}
