using ASP_SHOP.Models;
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
        IUnitOfWork db; // ShopContext
        public HomeController(IUnitOfWork db)
        {
            this.db = db;
        }
        int ItemsPerPage = 4;
        public ActionResult Index(int page = 1, string[] checkboxes=null, SortState sortOrder = SortState.TitleAsc, string searchString=null)
        {
            // главная страница (страница с товарами)
            PageInfo pageInfo; 
            List<Good> goods;

            if (!string.IsNullOrEmpty(searchString))
            {
                // ищем по строке поиска
                goods = db.Goods.GetList().Where(g => g.Category.CategoryName.ToLower().Contains(searchString.ToLower()) || g.Title.ToLower().Contains(searchString.ToLower())).ToList();
            }
            else
                goods = db.Goods.GetList().ToList();

            if (checkboxes == null)
            {
                checkboxes = new string[] { };
                pageInfo = new PageInfo()
                {
                    ItemsPerPage = ItemsPerPage,
                    ItemsCount = goods.Count(),
                    PageNumber = page 
                };
                
            }
            else
            {
                pageInfo = new PageInfo()
                { 
                    ItemsPerPage = ItemsPerPage,
                    ItemsCount = goods.Where(g => checkboxes.Contains(g.Category.CategoryName)).Count(),
                    PageNumber = page 
                };
                goods = goods.Where(g => checkboxes.Contains(g.Category.CategoryName)).ToList(); // применяем фильтры
            }

            switch (sortOrder) // сортировка
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
               
            goods = goods.Skip((page - 1) * ItemsPerPage).Take(ItemsPerPage).ToList(); // товары на 1 страницу
            HomeIndexViewModel viewModel = new HomeIndexViewModel()
            {
                PageInfo = pageInfo,
                Categories = db.Categories.GetList(),
                Goods = goods,
                filterInfo = new Models.FilterInfo(checkboxes,searchString),
                sortInfo = new SortInfo(sortOrder)
            };
            return View(model: viewModel);
        }

        public ActionResult GoodPage(int selectedGood)
        {
            // страница с выбранным товаром
            return View(model: db.Goods.GetById(selectedGood));
        }

        public ActionResult Categories()
        {
            // страница с категориями
            return View(model: db.Categories.GetList());
        }
    }
}