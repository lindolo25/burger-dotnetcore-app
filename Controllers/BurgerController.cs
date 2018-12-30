using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using burger_dotnetcore_app.Models;

namespace burger_dotnetcore_app.controllers
{
    public class BurgerController : Controller
    {
        BurgersDb _db = new BurgersDb();

        [HttpPost]
        public ActionResult Add()
        {
            return Json(new { isRunning = true }); 
        }

        [HttpPut]
        public ActionResult Edit()
        {
            return Json(new { isRunning = true }); 
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