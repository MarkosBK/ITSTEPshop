using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_SHOP.Models
{
    public class FilterInfo
    {
        // фильтрация товаров
        public FilterInfo(string[] selectedcategories=null, string searchString=null)
        {

            SelectedCategories = selectedcategories;
            SearchString = searchString;
        }
        public string[] SelectedCategories { get; private set; }   // выбранные категории
        public string SearchString { get; private set; }  // строка поиска
    }
}