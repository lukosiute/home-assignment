using System;
using System.Collections.Generic;

namespace GildedRoseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");
            IList<Inventory> inventory = new List<Inventory>
            {
                new Inventory
                {
                   Item = new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                   Type = ItemType.Normal
                },
                new Inventory
                {
                   Item =  new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                   Type = ItemType.Brie
                },
                new Inventory
                {
                   Item =  new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                   Type = ItemType.Normal
                },
                new Inventory
                {
                   Item =  new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                   Type =ItemType.Sulfuras
                },
                new Inventory
                {
                   Item =  new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                   Type =ItemType.Sulfuras
                },
                new Inventory
                {
                   Item =   new Item {Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 15, Quality = 20},
                   Type =ItemType.Pass
                },
                new Inventory
                {
                   Item =   new Item {Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 10, Quality = 49},
                   Type =ItemType.Pass
                },
                new Inventory
                {
                   Item =   new Item {Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 5, Quality = 49},
                   Type =ItemType.Pass
                },

            };


            // this conjured item does not work properly yet
            //new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}


            var app = new GildedRose(inventory);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < inventory.Count; j++)
                {
                    System.Console.WriteLine(inventory[j].Item.Name + ", " + inventory[j].Item.SellIn + ", " + inventory[j].Item.Quality);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
