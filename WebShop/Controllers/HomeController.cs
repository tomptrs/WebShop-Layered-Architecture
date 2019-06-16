using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Domain;
using WebShop.Services;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {
        ICustomerRepository repo;
        IShoppingBag repoShoppingBag;
        public HomeController(ICustomerRepository _repo, IShoppingBag _sb)
        {
            repo = _repo;
            repoShoppingBag = _sb;
        }
        public IActionResult Index()
        {
            var items = repo.GetAll();
            return View(items);
        }

        /*
         * Create a shopping bag & go to product page
         */
        public IActionResult CreateBag()
        {
            ShoppingBag sb = repoShoppingBag.CreateNewShoppingBag(1);
            return RedirectToAction("Index", "Products", new { sbagId = sb.Id });
           

        }
    }
}