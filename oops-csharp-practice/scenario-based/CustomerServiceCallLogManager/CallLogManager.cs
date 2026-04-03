using CG_Practice.oopsscenario.CustomerServiceCallLogManager;
using System;

namespace CG_Practice.oopsscenario.CustomerServiceCallLogManager
{
    class CallLogManager : ICallLogOperations
    {
        private CallLog[] logs;
        private int count;

        public CallLogManager(int size)
        {
            logs = new CallLog[size];
            count = 0;
        }

        public void AddCallLog(string phone, string msg, DateTime time)
        {
            if (count < logs.Length)
            {
                logs[count] = new CallLog(phone, msg, time);
                count++;
                Console.WriteLine("Call log added successfully!");
            }
            else
            {
                Console.WriteLine("Log storage is full!");
            }
        }

        public void SearchByKeyword(string keyword)
        {
            Console.WriteLine("=== SEARCH RESULTS FOR: " + keyword + " ===");
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (logs[i].msg.Contains(keyword))
                {
                    logs[i].showlog();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No logs found with keyword: " + keyword);
            }
        }

        public void FilterByTime(DateTime start, DateTime end)
        {
            Console.WriteLine("=== LOGS FROM " + start.ToString("yyyy-MM-dd") + " TO " + end.ToString("yyyy-MM-dd") + " ===");
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (logs[i].time >= start && logs[i].time <= end)
                {
                    logs[i].showlog();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No logs found in the specified time range");
            }
        }

        public void showalllogs()
        {
            Console.WriteLine("=== ALL CALL LOGS ===");
            for (int i = 0; i < count; i++)
            {
                logs[i].showlog();
            }
        }
    }
}
