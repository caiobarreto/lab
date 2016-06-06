using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Pedido
    {
        public int Id;
        public Product Produto;
        public Usuario Usuario;
    }
}