using System;
using System.Collections.Generic;
using System.Linq;

namespace burger_dotnetcore_app.Models
{
    public class IndexViewModel
    {
        public List<Burger> Burgers { get; set; }

        public List<Burger> DevouredBurgers { get; set; }
    }
}