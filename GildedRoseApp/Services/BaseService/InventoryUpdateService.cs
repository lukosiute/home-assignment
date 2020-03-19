using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseApp.Services
{
    public class InventoryUpdateService
    {
        public virtual void UpdateQuality(Item item)
        {
            if (item.SellIn <= 0)
            {
                item.Quality -= 2;
            }
            else
            {
                item.Quality -= 1;
            }
            ValidateQuality(item);

        }
        public virtual void LowerSellIn(Item item)
        {
            item.SellIn -= 1;
        }

        public virtual void ValidateQuality(Item item)
        {
            if (item.Quality < 0)
            {
                item.Quality = 0;
            }
            else if (item.Quality > 50)
            {
                item.Quality = 50;
            }

        }
    }
}
