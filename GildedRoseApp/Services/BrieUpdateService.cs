using GildedRoseApp.Interfaces;
using GildedRoseApp.Services;
using System.Threading.Tasks;

namespace GildedRoseApp
{
    internal class BrieUpdateService : ValidationService, IInventoryUpdateService
    {
        public async Task UpdateQuality(Item item)
        {
            if (item.SellIn > 0)
            {
                item.Quality += 1;
            }
            else
            {
                item.Quality += 2;
            }
        }
    }
}