using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TreeDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "tree-dnd",
                url: "tree-dnd/{*catchall}",
                defaults: new { controller = "Home", action = "TreeDnd" });

            routes.MapRoute(
                name: "uitree",
                url: "uitree/{*catchall}",
                defaults: new { controller = "Home", action = "UiTree" });

            routes.MapRoute(
                name: "ngjstree",
                url: "ngjstree/{*catchall}",
                defaults: new { controller = "Home", action = "NgJsTree" });

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
