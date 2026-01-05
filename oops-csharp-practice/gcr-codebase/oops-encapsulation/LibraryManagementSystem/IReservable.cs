using System;

namespace CG_Practice.oopscsharp.LibraryManagementSystem
{
    // interface for items that can be reserved
    interface IReservable
    {
        void ReserveItem(string borrowerName);
        bool CheckAvailability();
    }
}