using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Domain
{
    /*
     * Decorator pattern to add additional items to the shoppingbag
     */
    public class Verzekering:ShoppingBag
    {
        public ShoppingBag bag;
     
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


        public override double Cost()
        {
            return Price + bag.Cost();
        }
    }

}
