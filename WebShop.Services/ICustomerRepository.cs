using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Domain;

namespace WebShop.Services
{
    public interface ICustomerRepository
    {
         Customer GetById(int id);

         List<Customer> GetAll();

         void Insert(Customer customer);

        void Delete(Customer customer);
    }
}
