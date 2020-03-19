
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
        public void DailyService(int days)
        {
            for (var i = 0; i < days; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                foreach (var item in _items)
                {
                    Console.WriteLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
                }
                Console.WriteLine("");
                UpdateQuality();
            }
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                var service = UpdateServiceFactory.Create(item.Name);
                service.UpdateQuality(item);
                service.LowerSellIn(item);
            }
        }
    }
}
