using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TodoApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            this._context = context;

            if (this._context.TodoItems.Count() <= 0)
            {
                this._context.TodoItems.Add(new TodoItem { Name = "Item1" });
                this._context.SaveChanges();
            }
        }
    }
}
