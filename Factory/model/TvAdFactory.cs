using Factory.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.model
{
    public class TvAdFactory : IAdvertismentFactory
    {
        public IAdvertisment Create(Store store, params Item[] items)
        {
            return new TvAdvertisment(store, items);
        }
    }
}
