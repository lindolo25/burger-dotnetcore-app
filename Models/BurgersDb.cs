using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace burger_dotnetcore_app.Models
{
    public class BurgersDb : DbContext
    {
        public DbSet<Burger> burgers { get; set; }

        public BurgersDb(DbContextOptions<BurgersDb> options) : base(options) 
        {

        }
    }
}