using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }

        public List<ShoppingBag> Bags { get; set; }
    }
}
