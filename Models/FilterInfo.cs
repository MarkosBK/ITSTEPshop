using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_SHOP.Models
{
    public class FilterInfo
    {
        public FilterInfo(string[] selectedcategories=null)
        {

            SelectedCategories = selectedcategories;
        }
        public string[] SelectedCategories { get; private set; }   // выбранные категории
    }
}