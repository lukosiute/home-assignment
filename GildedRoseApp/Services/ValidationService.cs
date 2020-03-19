using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseApp.Services
{
    public abstract class ValidationService
    {
        public virtual void Validate(Item item)
        {
            if (item.Quality < 0)
            {
                item.Quality = 0;
            }
            else if (item.Quality > 50)
            {
                item.Quality = 50;
            }
        }
    }
}
