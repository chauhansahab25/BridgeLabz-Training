using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.FlashDealz
{
    public interface IFlashManager
    {
        void AddProduct(string name, int discount);
        void SortProducts();
        void DisplayDeals();
    }
}
