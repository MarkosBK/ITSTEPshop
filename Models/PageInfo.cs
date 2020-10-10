using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_SHOP.Models
{
    public class PageInfo
    {
        public int PageNumber { get; set; }
        public int ItemsCount { get; set; }
        public int ItemsPerPage { get; set; }
        public int PageCount { get { return (int)Math.Ceiling((decimal)ItemsCount / ItemsPerPage); } }
    }
}