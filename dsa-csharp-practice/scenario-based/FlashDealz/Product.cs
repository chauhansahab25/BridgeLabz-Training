using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.FlashDealz
{
    public class Product
    {
        public string Name { get; set; }
        public int DiscountPercentage { get; set; }

        public Product(string name, int discount)
        {
            Name = name;
            DiscountPercentage = discount;
        }
    }
}
