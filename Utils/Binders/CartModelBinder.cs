using ASP_SHOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_SHOP.Utils.Binders
{
    public class CartModelBinder : IModelBinder
    {
        private string sessionKey = "Cart";
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Cart cart = null;
            if (controllerContext.HttpContext.Session[sessionKey] != null)
            {
                cart = (Cart)controllerContext.HttpContext.Session[sessionKey];
            }
            else
            if (cart == null)
            {
                cart = new Cart();
                controllerContext.HttpContext.Session[sessionKey] = cart;
            }
            return cart;
        }
    }
}