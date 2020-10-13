using ASP_SHOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP_SHOP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "start",
            //    url: "",
            //    defaults: new
            //    {
            //        controller = "Home",
            //        action = "Index",
            //        page = 1,
            //        checkboxes = (string[])null,
            //        sortOrder = SortState.TitleAsc,
            //        searchString = (string)null
            //    }
            //    );
            //routes.MapRoute(
            //    name: "pages",
            //    url: "page/{page}",
            //    defaults: new
            //    {
            //        controller="Home",
            //        action="Index",
            //        checkboxes = (string[])null,
            //        sortOrder = SortState.TitleAsc,
            //        searchString = (string)null
            //    }
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
