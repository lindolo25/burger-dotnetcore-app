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
        private readonly BurgersDb _db;
        
        public HomeController(BurgersDb db)
        {
            _db = db;
        }
        
        [HttpGet]
        public ActionResult Index()
        {
            IndexViewModel view = new IndexViewModel()
            {
                Burgers = (from burger in _db.burgers
                          where burger.Devoured == false
                          select burger).ToList(),

                DevouredBurgers = (from burger in _db.burgers
                                  where burger.Devoured == true
                                  select burger).ToList()
            };
            return View(view); //File("", "text/html; charset=utf-8");
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