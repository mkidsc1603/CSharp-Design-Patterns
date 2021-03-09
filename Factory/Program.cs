using Factory.interfaces;
using Factory.model;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store() { Name = "Apple Store", Address = "apple city" };
            Item iphone15 = new Item() { Name = "IPhone 15", Price = "$2500", Description = "2025 brand new mobile" };
            IAdvertismentFactory lineNotiyfactory = new LineAdFactory();
            IAdvertismentFactory tvAdfactory = new TvAdFactory();

            IAdvertisment lineAD = lineNotiyfactory.Create(store, iphone15);
            IAdvertisment tvAD = tvAdfactory.Create(store, iphone15);

            Console.WriteLine(lineAD.Show());
            Console.WriteLine(tvAD.Show());

            Console.ReadLine();
        }
    }
}
