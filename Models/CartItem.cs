using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_SHOP.Models
{
    public class CartItem
    {
        public Good Good { get; set; }
        public int Quantity { get; set; }
    }
}