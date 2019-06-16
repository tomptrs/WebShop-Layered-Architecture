using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Domain;

namespace WebShop.ViewModel
{
    public class ShoppingItemViewModel
    {
        public int BagId { get; set; }
        public int ShoppingItemId { get; set; }
        public Product TheProduct { get; set; }
        public int Quantity { get; set; }
    }
}
