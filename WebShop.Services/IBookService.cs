using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Domain;

namespace WebShop.Services
{
    public interface IBookService
    {
        void Book(ShoppingBag bag);
    }
}
