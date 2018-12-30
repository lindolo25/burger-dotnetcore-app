using System;
using System.Collections.Generic;
using System.Linq;

namespace burger_dotnetcore_app.Models
{
    public class Burger
    {
        public int Id { get; set; }
        public string BurgerName { get; set; }
        public bool Devoured { get; set; }
    }
}