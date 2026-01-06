using CG_Practice.oopsscenario.CustomerServiceCallLogManager;
using System;

namespace CG_Practice.oopsscenario.CustomerServiceCallLogManager
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("TELECOM CALL LOG MANAGER");
            Console.WriteLine();

            // create manager with capacity for 10 logs
            ICallLogOperations mgr = new CallLogManager(10);
            CallLogManager manager = (CallLogManager)mgr;

            // add some sample call logs
            mgr.AddCallLog("9876543210", "Internet connection issue", new DateTime(2024, 1, 15, 10, 30, 0));
            mgr.AddCallLog("9123456789", "Bill payment query", new DateTime(2024, 1, 16, 14, 20, 0));
            mgr.AddCallLog("9555666777", "Network problem in area", new DateTime(2024, 1, 17, 9, 15, 0));
            mgr.AddCallLog("9888999000", "Want to upgrade plan", new DateTime(2024, 1, 18, 16, 45, 0));
            mgr.AddCallLog("9111222333", "Internet speed is slow", new DateTime(2024, 1, 19, 11, 10, 0));

            Console.WriteLine();

            // show all logs
            manager.showalllogs();

            // search by keyword using interface
            mgr.SearchByKeyword("Internet");

            // filter by time range using interface
            DateTime startDate = new DateTime(2024, 1, 16);
            DateTime endDate = new DateTime(2024, 1, 18);
            mgr.FilterByTime(startDate, endDate);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
