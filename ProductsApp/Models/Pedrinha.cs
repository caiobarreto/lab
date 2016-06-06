using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProductsApp.Models
{
    public class Pedrinha
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}