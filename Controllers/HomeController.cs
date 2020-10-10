﻿using ASP_SHOP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ASP_SHOP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        IUnitOfWork db;
        public HomeController(IUnitOfWork db)
        {
            this.db = db;
        }
        public ActionResult Index(int page = 1, string[] checkboxes=null, SortState sortOrder = SortState.TitleAsc)
        {
            PageInfo pageInfo;
            List<Good> goods;
            int ItemsPerPage = 4;
            if (checkboxes == null)
            {
                checkboxes = new string[] { };
                goods = db.Goods.GetList().Skip((page - 1) * ItemsPerPage).Take(ItemsPerPage).ToList();
                pageInfo = new PageInfo() { ItemsPerPage = ItemsPerPage, ItemsCount = db.Goods.GetList().Count(), PageNumber = page };
            }
            else
            {
                goods = db.Goods.GetList().Where(g => checkboxes.Contains(g.Category.CategoryName)).Skip((page - 1) * ItemsPerPage).Take(ItemsPerPage).ToList();
                pageInfo = new PageInfo() { ItemsPerPage = ItemsPerPage, ItemsCount = db.Goods.GetList().Where(g => checkboxes.Contains(g.Category.CategoryName)).Count(), PageNumber = page };
            }

            
            switch (sortOrder)
            {
                case SortState.PriceAsc:
                    goods = goods.OrderBy(s => s.Price).ToList();
                    break;
                case SortState.TitleDesc:
                    goods = goods.OrderByDescending(s => s.Title).ToList();
                    break;
                case SortState.PriceDesc:
                    goods = goods.OrderByDescending(s => s.Price).ToList();
                    break;
                default:
                    goods = goods.OrderBy(s => s.Title).ToList();
                    break;
            }
            
            HomeIndexViewModel viewModel = new HomeIndexViewModel()
            {
                PageInfo = pageInfo,
                Categories = db.Categories.GetList(),
                Goods = goods,
                filterInfo = new Models.FilterInfo(checkboxes),
                sortInfo = new SortInfo(sortOrder)
            };
            return View(model: viewModel);
        }
        
        //[HttpPost]
        //public ActionResult Filter(int page=1, string[] checkboxes=null)
        //{
        //    int ItemsPerPage = 4;

        //    if (checkboxes != null)
        //    {
        //        PageInfo pageInfo = new PageInfo() { ItemsPerPage = ItemsPerPage, ItemsCount = db.Goods.GetList().Where(g=>checkboxes.Contains(g.Category.CategoryName)).Count(), PageNumber = page };
        //        HomeIndexViewModel viewModel = new HomeIndexViewModel()
        //        {
        //            PageInfo = pageInfo,
        //            Categories = db.Categories.GetList(),
        //            Goods = db.Goods.GetList().Where(g => checkboxes.Contains(g.Category.CategoryName)).Skip((page - 1) * ItemsPerPage).Take(ItemsPerPage)
        //        };
        //        return View("Index", model: viewModel);
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index");
        //    }
            

        //}

        public ActionResult Categories()
        {
            return View(model: db.Categories.GetList());
        }
    }
}