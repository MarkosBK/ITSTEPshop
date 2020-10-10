using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_SHOP.Models
{
    public class Good:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ImageForGood> Images { get; set; }

        public Good()
        {
            Comments = new HashSet<Comment>();
            Images = new HashSet<ImageForGood>();
        }
    }
}