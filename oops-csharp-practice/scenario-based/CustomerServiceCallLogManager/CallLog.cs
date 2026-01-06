using CG_Practice.oopsscenario.CustomerServiceCallLogManager;
using System;

namespace CG_Practice.oopsscenario.CustomerServiceCallLogManager
{
    
    class CallLog : IDisplayable
    {
        public string phone;
        public string msg;
        public DateTime time;

        public CallLog(string phoneNum, string message, DateTime timestamp)
        {
            phone = phoneNum;
            msg = message;
            time = timestamp;
        }

        public void showlog()
        {
            Console.WriteLine("Phone: " + phone + " | Time: " + time.ToString("dd-MM-yyyy HH:mm"));
            Console.WriteLine("Message: " + msg);
            Console.WriteLine("------------------------");
        }
    }
}
