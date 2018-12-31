using System;
using System.Collections.Generic;
using System.Linq;

namespace burger_dotnetcore_app.Models
{
    public class IndexViewModel
    {
        public ICollection<Burger> Burgers { get; set; }

        public ICollection<Burger> DevouredBurgers { get; set; }
    }
}