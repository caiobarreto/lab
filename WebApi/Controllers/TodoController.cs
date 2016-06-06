using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet;
using WebApi.Models;
using System.Xml.Linq;
using System.Web;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : ApiController
    {
        public TodoController(ITodoRepository todoItems)
        {
            TodoItems = todoItems;
        }
        public ITodoRepository TodoItems { get; set; }

        public IEnumerable<TodoItem> GetAll()
        {
            return TodoItems.GetAll();
        }
        
    }
}
