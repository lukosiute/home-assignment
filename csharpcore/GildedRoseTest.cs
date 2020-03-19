using Xunit;
using System.Collections.Generic;
using GildedRoseApp;

namespace GildedRoseApp.Tests
{
    public class GildedRoseTest
    {

        [Fact]
        public void Quality_is_never_negative()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Random item", SellIn = 3, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality);
        }

        [Fact]
        public void Normal_item_quality_drops_1_a_day()
        {
            IList<Item> Items = new List<Item>
            {
                new Item{ Name = "Random item", SellIn = 12, Quality = 5 } ,
                new Item { Name = "Aged Brie", SellIn = 9, Quality = 5 }
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(4, Items[0].Quality);
            Assert.NotEqual(4, Items[1].Quality);
        }

        [Fact]
        public void After_sell_date_quality_degrades_x2()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Random item", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(3, Items[0].Quality);
        }

        [Fact]
        public void Aged_Brie_quality_increases()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 9, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(6, Items[0].Quality);
        }

        [Fact]
        public void Aged_Brie_quality_increases_x2_after_sell_date()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(7, Items[0].Quality);
        }

        [Fact]
        public void Backstage_passes_quality_increases_by_2_10_days_and_less_to_the_concert()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 48 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(50, Items[0].Quality);
        }

        [Fact]
        public void Backstage_pass_quality_increases_by_3_5_days_and_less_to_the_concert()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 47 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(50, Items[0].Quality);
        }
        [Fact]
        public void Backstage_pass_quality_is_0_after_the_concert()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 47 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality);
        }

        [Fact]
        public void Quality_is_never_more_than_50()
        {
            IList<Item> Items = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = 9, Quality = 50 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49 }
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(50, Items[0].Quality);
            Assert.Equal(50, Items[1].Quality);
        }

        [Fact]
        public void Sulfuras_quality_is_80_and_never_decreases()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 }, };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(80, Items[0].Quality);
        }
        [Fact]
        public void SellIn_value_lowers_1_a_day()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 7, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(6, Items[0].Quality);
        }
        [Fact]
        public void Sulfuras_sellInn_value_never_changes()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 2, Quality = 80 }, };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(2, Items[0].SellIn);
        }

        [Fact]
        public void Conjured_quality_decreases_x2()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured", SellIn = 2, Quality = 50 }, };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(48, Items[0].Quality);
        }
    }
}