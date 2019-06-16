using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Domain;

namespace WebShop.ViewModel
{
    public class ProductViewModel
    {
        public Product MyProduct { get; set; }
    }

    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public ProductListViewModel()
        {
            Products = new List<Product>();
        }

        public void Add(Product product)
        {
            Products.Add(product);
        }
    }
}
