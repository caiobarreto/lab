using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsApp.Models;


namespace ProductsApp.Controllers
{
    public class UsuariosController : ApiController
    {
        public UsuariosController(IUsuarioRepository usuarios)
        {
            Usuarios = usuarios;
        }
        public IUsuarioRepository Usuarios { get; set; }

        public IEnumerable<Usuario> GetAll()
        {
            return Usuarios.GetAll();
        }

        Usuario[] usuarios = new Usuario[]
        {
            new Usuario { Id = 1, Name="Usuário 01", LastName="Sobrenome" },
            new Usuario { Id = 2, Name="Usuário 02", LastName="Sobrenome" },
            new Usuario { Id = 3, Name="Usuário 03", LastName="Sobrenome" },
            new Usuario { Id = 4, Name="Usuário 04", LastName="Sobrenome" },
            new Usuario { Id = 5, Name="Usuário 05", LastName="Sobrenome" },
            new Usuario { Id = 6, Name="Usuário 06", LastName="Sobrenome" },
            new Usuario { Id = 7, Name="Usuário 07", LastName="Sobrenome" },
            new Usuario { Id = 8, Name="Usuário 08", LastName="Sobrenome" },
            new Usuario { Id = 9, Name="Usuário 09", LastName="Sobrenome" },
            new Usuario { Id = 10, Name="Usuário 010", LastName="Sobrenome" },
            new Usuario { Id = 11, Name="Usuário 011", LastName="Sobrenome" },
            new Usuario { Id = 12, Name="Usuário 012", LastName="Sobrenome" },
            new Usuario { Id = 13, Name="Usuário 013", LastName="Sobrenome" }
        };

        // GET api/<controller>
        public IEnumerable<Usuario> Get()
        {
            return usuarios;
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var usuario = usuarios.FirstOrDefault((p) => p.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}