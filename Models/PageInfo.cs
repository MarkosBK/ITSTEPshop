using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_SHOP.Models
{
    public class PageInfo
    {
        public int PageNumber { get; set; } // номер текущей страницы
        public int ItemsCount { get; set; } // кол-во товаров
        public int ItemsPerPage { get; set; } // кол-во товаров на страницу
        public int PageCount { get { return (int)Math.Ceiling((decimal)ItemsCount / ItemsPerPage); } } // кол-во создаваемых страниц с товарами
    }
}