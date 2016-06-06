using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class PedidosController : ApiController
    {
        Pedido[] pedidos = new Pedido[]
            {
                new Pedido
                    {   Id = 1,
                        Usuario = new Usuario { Id = 1, Name="Usuário 01", LastName="Sobrenome" },
                        Produto = new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }
                    }
            };       

        // GET api/<controller>
        public IEnumerable<Pedido> Get()
        {
            return pedidos;
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var pedido = pedidos.FirstOrDefault((p) => p.Id == id);
            if (pedido == null)
            {
                return NotFound();
            }
            return Ok(pedido);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}