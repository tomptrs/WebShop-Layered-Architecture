using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Domain;
using WebShop.ViewModel;

namespace WebShop.Services
{
    public interface IProductRepository
    {
        Product GetById(int id);

        ProductListViewModel GetAll();

        void Insert(Product product);

        void Delete(Product product);
    }
}
