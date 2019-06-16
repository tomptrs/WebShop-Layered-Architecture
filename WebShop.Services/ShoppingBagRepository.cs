using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Data;
using WebShop.Domain;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebShop.ViewModel;

namespace WebShop.Services
{
    public class ShoppingBagRepository:IShoppingBag
    {
        ShopDbContext context;
        public ShoppingBagRepository(ShopDbContext ctx)
        {
            context = ctx;
        }

        public void AddItemToShoppingBag(ShoppingBag bag, int productId)
        {

            bag.ShoppingItems.Add(new ShoppingItem() { ProductId = productId, Quantity = 1 });
            context.ShoppingBags.Update(bag);
            context.SaveChanges();
        }

        /*
         * test cases => no customer found
         */
        public ShoppingBag CreateNewShoppingBag(int customerId)
        {
            var cust = context.Customers.Where(c => c.Id == customerId).Single();
            ShoppingBag sb = new ShoppingBag()
            {
                Customer = cust,
                CustomerId = customerId
            };

             context.ShoppingBags.Add(sb);
             context.SaveChanges();
            return sb;
        }

        public void Delete(ShoppingBag product)
        {
            throw new NotImplementedException();
        }

        public List<ShoppingBag> GetAll()
        {
            throw new NotImplementedException();
        }

        public ShoppingBag GetById(int id)
        {
            var bag = context.ShoppingBags.Where(s => s.CustomerId == id)
                .Include(sb=>sb.Customer)
                .Include(sb=>sb.ShoppingItems).ThenInclude(p=>p.Product)                
                .SingleOrDefault();

            //if no bag  is found
            if(bag == null)
            {
                return CreateNewShoppingBag(id);
            }
            return bag;
        }      

        public void Insert(ShoppingBag product)
        {
            throw new NotImplementedException();
        }

        public void UpdateShoppingItem(int shoppingItemId, int quantity)
        {
            var item = context.ShoppingItems.Where(si => si.Id == shoppingItemId).Single();

            item.Quantity = quantity;
            context.Update(item);
            context.SaveChanges();
        }

        List<ShoppingItemViewModel> IShoppingBag.GetById2(int id)
        {
            var bag = context.ShoppingBags.Where(s => s.CustomerId == id)
              .Include(sb => sb.Customer)
              .Include(sb => sb.ShoppingItems).ThenInclude(p => p.Product)
              .SingleOrDefault();

            List<ShoppingItemViewModel> list = new List<ShoppingItemViewModel>();



            foreach(var item in bag.ShoppingItems)
            {
                list.Add(new ShoppingItemViewModel()
                {
                    BagId = bag.Id,
                    ShoppingItemId = item.Id,
                    TheProduct = item.Product,
                    Quantity = item.Quantity
                });
            }

           
            return list;
        }
    }
}
