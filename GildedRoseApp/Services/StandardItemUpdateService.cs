using GildedRoseApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseApp.Services
{
    public class StandardItemUpdateService : ValidationService,  IInventoryUpdateService
    {
        public async Task UpdateQuality(Item item)
        {
            if (item.SellIn <= 0)
            {
                item.Quality -= 2;
            }
            else
            {
                item.Quality -= 1;
            }

        }
    }
}
