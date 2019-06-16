using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Domain
{
    public class ShoppingBag
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public List<ShoppingItem> ShoppingItems { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public virtual double Cost()
        {
            double total = 0;
            foreach(var item in ShoppingItems)
            {
                total += item.Product.Price;
            }
            return total;
        }
    }
}
