using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HarryPotter.Domain
{
    public class Order
    {
        public string ClientEmail { get; set; }
        public IList<OrderItem> Items { get; set; }

        public Order()
        {
            this.Items = new List<OrderItem>();
        }

        public Order(IList<Book> books)
        {
            this.Items = new List<OrderItem>();
            foreach (Book book in books)
                this.Items.Add(new OrderItem(book));
        }
    }
}
