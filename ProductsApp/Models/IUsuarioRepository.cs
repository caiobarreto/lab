using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApp.Models
{
    public interface IUsuarioRepository
    {
        void Add(Usuario item);
        IEnumerable<Usuario> GetAll();
        Usuario Find(string key);
        Usuario Remove(string key);
        void Update(Usuario item);
    }
}
