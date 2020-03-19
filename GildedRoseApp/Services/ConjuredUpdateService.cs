using GildedRoseApp.Services;

namespace GildedRoseApp.Services
{
    internal class ConjuredUpdateService : InventoryUpdateService
    {
        public override void UpdateQuality(Item item)
        {
            if (item.SellIn <= 0)
            {
                item.Quality -= 4;
            }
            else
            {
                item.Quality -= 2;
            }
            ValidateQuality(item);
        }
    }
}