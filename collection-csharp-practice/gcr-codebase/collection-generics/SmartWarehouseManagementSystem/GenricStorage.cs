using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.dsascenario.SmartWarehouseManagementSystem
{
    
      public class GenricStorage<T> where T : WareHouseSystem
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

     
        public IReadOnlyList<T> GetAllItems()
        {
            return items;
        }

        public void DisplayAllItems()
        {
            foreach (T item in items)
            {
                item.Show();
            }
        }
    }

}

