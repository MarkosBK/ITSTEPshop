using ASP_SHOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ASP_SHOP.Utils
{
    public static class CustomHelpers
    {
        public static MvcHtmlString PageBuilder(this HtmlHelper html, PageInfo pageInfo, Func<int, string> pageUrl)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 1; i <= pageInfo.PageCount; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();
                tag.AddCssClass("button");
                if (i == pageInfo.PageNumber)
                {
                    tag.AddCssClass("button--select");
                }
                else
                    tag.AddCssClass("button--static");
                builder.Append(tag.ToString());
            }

            return new MvcHtmlString(builder.ToString());
        }
    }
}