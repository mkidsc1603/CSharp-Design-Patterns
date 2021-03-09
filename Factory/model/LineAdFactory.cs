using Factory.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.model
{
    public class LineAdFactory : IAdvertismentFactory
    {
        public IAdvertisment Create(Store store, params Item[] items)
        {
            return new LineAdvertisment(store, items);
        }
    }
}
