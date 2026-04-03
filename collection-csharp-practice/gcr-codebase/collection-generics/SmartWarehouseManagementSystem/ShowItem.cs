using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.dsascenario.SmartWarehouseManagementSystem
{
    public class ShowItem
    {
         public static void DisplayWarehouseItems(IReadOnlyList<WareHouseSystem> items)
    {
        foreach (var item in items)
        {
            item.Show();
        }
    }
    }
}
