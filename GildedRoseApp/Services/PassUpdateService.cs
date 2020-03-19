using GildedRoseApp.Interfaces;
using System.Threading.Tasks;
namespace GildedRoseApp.Services
{
    internal class PassUpdateService : ValidationService, IInventoryUpdateService
    {
        public async Task UpdateQuality(Item item)
        {
            if (item.SellIn > 10)
            {
                item.Quality += 1;
            }
            else if (item.SellIn <= 10 && item.SellIn > 5)
            {
                item.Quality += 2;
            }
            else if (item.SellIn <= 5 && item.SellIn > 0)
            {
                item.Quality += 3;
            }
            else
            {
                item.Quality = 0;
            }
        }
    }
}