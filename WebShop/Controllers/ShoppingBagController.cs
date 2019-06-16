using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Domain;
using WebShop.Services;
using WebShop.ViewModel;

namespace WebShop.Controllers
{
    public class ShoppingBagController : Controller
    {
        IShoppingBag repo;
        public ShoppingBagController(IShoppingBag _repo)
        {
            repo = _repo;
        }
        public IActionResult Index()
        {
            /*  var shoppingBag = repo.GetById2(1);
              ViewData["bag"] = shoppingBag;
              return View(shoppingBag);
              */
            var shoppingBag = repo.GetById(1);
            ViewData["bag"] = shoppingBag;
            return View(shoppingBag);
        }

        public IActionResult AddToBag(int id)
        {
            //1. getShoppingBag (presume we are user 1
            var shoppingBag = repo.GetById(1);

            //2. Add item to my shopping bag
            repo.AddItemToShoppingBag(shoppingBag, id);


            return RedirectToAction("Index");
        }

        /*
         * How to pass data from view to controller
         */
        public IActionResult ChangeQuantity(ShoppingItem data)
        {
            
            return View();
        }

        public IActionResult test(ShoppingItemViewModel data)
        {
            repo.UpdateShoppingItem(data.ShoppingItemId, data.Quantity);

            return RedirectToAction("Index");
        }
    }
}