using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TreeDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult TreeDnd()
        {
            ViewBag.Message = "angular-tree-dnd plugin";
            ViewBag.Link = @"https://github.com/thienhung1989/angular-tree-dnd";

            return View();
        }

        public ActionResult UiTree()
        {
            ViewBag.Message = "angular-ui-tree plugin";
            ViewBag.Link = @"https://github.com/angular-ui-tree/angular-ui-tree";

            return View();
        }

        public ActionResult NgJsTree()
        {
            ViewBag.Message = "ngJsTree plugin";
            ViewBag.Link = @"https://github.com/ezraroi/ngJsTree";

            return View();
        }
    }
}