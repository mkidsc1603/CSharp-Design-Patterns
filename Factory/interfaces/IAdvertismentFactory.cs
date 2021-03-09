using Factory.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.interfaces
{
    public interface IAdvertismentFactory
    {
        IAdvertisment Create(Store store, params Item[] items);
    }
}
