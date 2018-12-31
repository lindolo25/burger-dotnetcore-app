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
        private readonly BurgersDb _db;
        
        public BurgerController(BurgersDb db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<ActionResult<Burger>> Add([FromBody] Burger newBurger)
        {
            if(!ModelState.IsValid) return Json(false);
            
            _db.burgers.Add(newBurger);
            await _db.SaveChangesAsync();

            return newBurger;
        }

        [HttpPut]
        [Route("/api/burger/edit/{Id:int}")]
        public async Task<ActionResult<Burger>> Edit([FromRoute] int Id)
        {
            Burger burger =  await _db.burgers.FindAsync(Id);
            if(burger == null) return Json(false);

            burger.Devoured = true;
            await _db.SaveChangesAsync();
            
            return burger;
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