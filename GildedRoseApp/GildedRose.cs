using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseApp
{
    public class GildedRose
    {
        private IList<Inventory> _items;
        public GildedRose(IList<Inventory> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                item.Item.Quality += UpdateSellIn(item.Type, item.Item.SellIn, item.Item.Quality);



                if (item.Type != ItemType.Sulfuras)
                {
                    item.Item.Quality = item.Item.Quality <= 50 ? item.Item.Quality : 50;
                    item.Item.SellIn -= 1;
                }
            }
        }

        public static int UpdateSellIn(ItemType type, int days, int current)
        {
            return type switch
            {
                ItemType.Brie when days <= 0 => 2,
                ItemType.Brie when days > 0 => 1,
                ItemType.Normal when days < 0 => -2,
                ItemType.Normal when days >= 0 => -1,
                ItemType.Sulfuras => 0,
                ItemType.Pass when days > 10 => 1,
                ItemType.Pass when days <= 10 && days > 5 => 2,
                ItemType.Pass when days <= 5 && days >= 0 => 3,
                ItemType.Pass when days < 0 => -current,
                _ => throw new NotImplementedException("bazinga")
            };
        }
    }
}
