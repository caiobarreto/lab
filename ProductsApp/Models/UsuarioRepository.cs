using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class UsuarioRepository : IUsuarioRepository
    {
        static ConcurrentDictionary<string, Usuario> _todos =
              new ConcurrentDictionary<string, Usuario>();

        public UsuarioRepository()
        {
            Add(new Usuario { Name = "Item1" });
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _todos.Values;
        }

        public void Add(Usuario item)
        {
            item.Key = Guid.NewGuid().ToString();
            _todos[item.Key] = item;
        }

        public Usuario Find(string key)
        {
            Usuario item;
            _todos.TryGetValue(key, out item);
            return item;
        }

        public Usuario Remove(string key)
        {
            Usuario item;
            _todos.TryGetValue(key, out item);
            _todos.TryRemove(key, out item);
            return item;
        }

        public void Update(Usuario item)
        {
            _todos[item.Key] = item;
        }
    }
}