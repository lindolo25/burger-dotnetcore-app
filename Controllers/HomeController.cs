using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using burger_dotnetcore_app.Models;

namespace burger_dotnetcore_app.controllers
{
    public class HomeController : Controller
    {
        BurgersDb _db = new BurgersDb();
        
        [HttpGet]
        public ActionResult Index()
        {
            return View(); //File("", "text/html; charset=utf-8");
        }

        protected override void Dispose(bool disposing)
        {
            if(_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}