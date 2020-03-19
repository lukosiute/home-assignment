using GildedRoseApp.Interfaces;
using GildedRoseApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseApp
{
    public class GildedRose
    {
        private IList<Item> _items;
        public GildedRose(IList<Item> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                var type = GetItemType(item);
                var service = UpdateServiceFactory.Create(type);
                var bla = service.UpdateQuality(item);
                service.Validate(item);
                if(type != ItemType.Sulfuras)
                {
                    item.SellIn--;
                }
 
            }
        }

       
        public ItemType GetItemType(Item item)
        {
            if (item.Name.Contains("Aged Brie"))
            {
                return ItemType.Brie;
            }
            if (item.Name.Contains("Sulfuras"))
            {
                return ItemType.Sulfuras;
            }
            if (item.Name.Contains("Backstage passes"))
            {
                return ItemType.Pass;
            }
            else
            {
                return ItemType.Normal;
            }
        }

    }
}
