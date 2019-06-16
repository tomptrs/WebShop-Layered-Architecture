using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Domain;

namespace WebShop.ViewModel
{
    public class ShoppingBagViewModel
    {
        public int ShoppingBagId { get; set; }
        public ShoppingBag theShoppingBag { get; set; }
        public List<ShoppingItem> shoppingItems { get; set; }
        public List<Product> ProductList { get; set; }
        public Customer theCustomer { get; set; }

    }
}
