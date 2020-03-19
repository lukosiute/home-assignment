namespace GildedRoseApp.Services
{
    internal class PassUpdateService : InventoryUpdateService
    {
        public override void UpdateQuality(Item item)
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
            ValidateQuality(item);
        }
    }
}