using GildedRoseApp.Interfaces;
using GildedRoseApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseApp
{
    public static class UpdateServiceFactory 
    {
        public static IInventoryUpdateService Create(ItemType type)
        {
            return type switch
            {
                ItemType.Normal => new StandardItemUpdateService(),
                ItemType.Brie => new BrieUpdateService(),
                ItemType.Pass => new PassUpdateService(),
                ItemType.Sulfuras => new SulfurasUpdateService(),
                _ => throw new NotImplementedException("bazinga")
            };
        }
    }
}
