using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Data;
using WebShop.Domain;
using System.Linq;
using WebShop.ViewModel;

namespace WebShop.Services
{
    public class ProductRepository : IProductRepository
    {

        ShopDbContext context;
        public ProductRepository(ShopDbContext ctx)
        {
            context = ctx;
        }

        public void Delete(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
        }

        public ProductListViewModel GetAll()
        {
            ProductListViewModel vm = new ProductListViewModel();
            vm.Products = context.Products.ToList();
            return vm;
        }

        public Product GetById(int id)
        {
            return context.Products.Where(p => p.Id == id).SingleOrDefault();
        }

        public void Insert(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
    }
}
