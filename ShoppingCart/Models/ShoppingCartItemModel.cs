using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class ShoppingCartItemModel
    {

        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}