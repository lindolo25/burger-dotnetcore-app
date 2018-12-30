using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace burger_dotnetcore_app.controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Content("Hello dotNet Core MVC"); //File("", "text/html; charset=utf-8");
        }
    }
}