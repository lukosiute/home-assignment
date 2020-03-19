
using GildedRoseApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseApp
{
    public static class UpdateServiceFactory
    {
        public static InventoryUpdateService Create(string name)
        {
            if (name.Contains("Aged Brie"))
            {
                return new BrieUpdateService();
            }
            if (name.Contains("Sulfuras"))
            {
                return new SulfurasUpdateService();

            }
            if (name.Contains("Backstage passes"))
            {
                return new PassUpdateService();
            }
            else
            {
                return new StandardItemUpdateService();
            }
        }
    }
}

