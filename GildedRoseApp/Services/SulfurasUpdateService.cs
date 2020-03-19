using GildedRoseApp.Interfaces;
using System.Threading.Tasks;

namespace GildedRoseApp.Services
{
    internal class SulfurasUpdateService : ValidationService, IInventoryUpdateService
    {

        public async  Task UpdateQuality(Item item)
        {
            
        }

        public override void Validate(Item item)
        {
            
            item.Quality = item.Quality == 80 ? item.Quality :80;
        }
    }
}