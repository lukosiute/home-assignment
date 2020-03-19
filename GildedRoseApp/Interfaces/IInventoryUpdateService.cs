using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseApp.Interfaces
{
    public interface IInventoryUpdateService
    {
        public Task UpdateQuality(Item item);
        public void Validate(Item item);
    }
}
