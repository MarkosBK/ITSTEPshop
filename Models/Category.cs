using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_SHOP.Models
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Good> Goods { get; set; }
        public Category()
        {
            Goods = new HashSet<Good>();
        }
    }
}