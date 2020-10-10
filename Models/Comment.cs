using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_SHOP.Models
{
    public class Comment:IEntity
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public string UserName { get; set; }
        public int GoodId { get; set; }
        public virtual Good Good { get; set; }
    }

}