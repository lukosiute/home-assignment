
using System.Threading.Tasks;

namespace GildedRoseApp.Services
{
    internal class SulfurasUpdateService : InventoryUpdateService
    {
        public override void ValidateQuality(Item item)
        {

            item.Quality = item.Quality == 80 ? item.Quality : 80;
        }
        public override void LowerSellIn(Item item)
        {
        }
    }
}