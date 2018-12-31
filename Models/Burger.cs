using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace burger_dotnetcore_app.Models
{
    [Table("burgers")]
    public class Burger
    {
        [Column("burger_id")]
        public int Id { get; set; }
        
        [Column("burger_name")]
        [Required]
        public string BurgerName { get; set; }

        [Column("is_devoured")]
        public bool Devoured { get; set; }
    }
}