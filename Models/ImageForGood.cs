using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_SHOP.Models
{
    public class ImageForGood: IEntity
    {
        public int Id { get; set; }
        public int? GoodId { get; set; }
        public virtual Good Good { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public bool IsLogo { get; set; }
    }
}