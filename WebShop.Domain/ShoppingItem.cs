using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Domain
{
    public class ShoppingItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
