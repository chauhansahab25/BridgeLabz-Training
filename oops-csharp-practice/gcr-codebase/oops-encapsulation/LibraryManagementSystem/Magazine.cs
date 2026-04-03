using System;

namespace CG_Practice.oopscsharp.LibraryManagementSystem
{
    // magazine class
    class Magazine : LibraryItem, IReservable
    {
        private string issueDate;
        private bool isAvailable;

        public string IssueDate { get { return issueDate; } set { issueDate = value; } }

        public Magazine(int id, string title, string author, string issue) : base(id, title, author)
        {
            issueDate = issue;
            isAvailable = true;
        }

        public override int GetLoanDuration()
        {
            return 7; // 1 week for magazines
        }

        public void ReserveItem(string borrowerName)
        {
            if (isAvailable)
            {
                isAvailable = false;
                BorrowerData = borrowerName;
                Console.WriteLine("Magazine reserved for " + borrowerName);
            }
            else
            {
                Console.WriteLine("Magazine already reserved");
            }
        }

        public bool CheckAvailability()
        {
            return isAvailable;
        }
    }
}