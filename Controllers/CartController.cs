﻿using ASP_SHOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_SHOP.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        IUnitOfWork db;
        public CartController(IUnitOfWork db)
        {
            this.db = db;
        }
        public ActionResult Index(Cart cart)
        {
            return View(model: cart);
        }

        public ActionResult AddToCart(int id, Cart cart)
        {
            Good good = db.Goods.GetById(id);
            if (good != null)
                cart.AddItem(good, 1);
            return PartialView("AddToCart", model: good);
        }
        
        public ActionResult DeleteFromCart(int id, Cart cart)
        {
            Good good = db.Goods.GetById(id);
            cart.RemoveItem(good);
            return PartialView("Cart", model: cart);
        }     
        
        public ActionResult DeleteFromCartButton(int id, Cart cart)
        {
            Good good = db.Goods.GetById(id);
            cart.RemoveItem(good);
            return PartialView("AddToCart", model: good);
        }

        public ActionResult GoodPage(int selectedGood)
        {
            // страница с выбранным товаром
            return View(model: db.Goods.GetById(selectedGood));
        }
    }
}