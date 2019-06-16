using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Domain;
using WebShop.ViewModel;

namespace WebShop.Services
{
    public interface IShoppingBag
    {
        ShoppingBag GetById(int id);

        List<ShoppingItemViewModel> GetById2(int id);

        List<ShoppingBag> GetAll();

        void Insert(ShoppingBag product);

        void Delete(ShoppingBag product);

        void UpdateShoppingItem(int shoppingItemId, int quantity);

        ShoppingBag CreateNewShoppingBag(int customerId);

        void AddItemToShoppingBag(ShoppingBag bag, int productId);

      
    }
}
