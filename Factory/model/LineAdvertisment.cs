using Factory.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.model
{
    public class LineAdvertisment : IAdvertisment
    {
        private List<Item> Items { get; set; } = new List<Item>();
        private Store Store { get; set; }

        public LineAdvertisment(Store store, params Item[] items)
        {
            this.Store = store;
            this.Items.AddRange(items);
        }

        public string Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("LINE Notification:");
            sb.AppendLine($"{this.Store.Name} new product is released:");
            foreach(Item item in Items)
            {
                sb.AppendLine($"{item.Name} {item.Price}: {item.Description}");
            }
            sb.AppendLine($"Feel free to visit by {Store.Address}");

            return sb.ToString();
        }
    }
}
