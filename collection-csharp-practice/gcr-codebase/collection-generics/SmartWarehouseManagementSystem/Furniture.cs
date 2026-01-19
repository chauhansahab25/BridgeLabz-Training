using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace CG_Practice.dsascenario.SmartWarehouseManagementSystem
{
 
        public class Furniture : WareHouseSystem
        {
            public string Material { get; set; }

            public Furniture(string name, double price, string material)
                : base(name, price)
            {
                Material = material;
            }

            public override void Show()
            {
                Console.WriteLine($"Furniture: {Name}, Price: {Price}, Material: {Material}");
            }
        }
    }

