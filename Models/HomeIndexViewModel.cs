using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_SHOP.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Good> Goods { get; set; }
        public FilterInfo filterInfo { get; set; }
        public SortInfo sortInfo { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}