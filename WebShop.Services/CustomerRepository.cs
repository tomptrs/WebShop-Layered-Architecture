using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Data;
using WebShop.Domain;
using System.Linq;

namespace WebShop.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        //why using (var context = {}
        ShopDbContext context;
        public CustomerRepository(ShopDbContext ctx)
        {
            context = ctx;                
        }

        public void Delete(Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return context.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return context.Customers.Where(c => c.Id == id).SingleOrDefault();
        }

        public void Insert(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }
    }
}
