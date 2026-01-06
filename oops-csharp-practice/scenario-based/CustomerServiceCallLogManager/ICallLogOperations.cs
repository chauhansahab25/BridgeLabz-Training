using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopsscenario.CustomerServiceCallLogManager
{
    interface ICallLogOperations
    {
        void AddCallLog(string phone, string msg, DateTime time);
        void SearchByKeyword(string keyword);
        void FilterByTime(DateTime start, DateTime end);
    }
}
