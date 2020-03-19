
using GildedRoseApp.Services;
using System.Threading.Tasks;

namespace GildedRoseApp
{
    internal class BrieUpdateService :  InventoryUpdateService
    {
        public override void UpdateQuality(Item item)
        {
            if (item.SellIn > 0)
            {
                item.Quality += 1;
            }
            else
            {
                item.Quality += 2;
            }
            ValidateQuality(item);
        }

  
    }
}