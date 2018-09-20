using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoAPI.Controllers.V1 
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : Controller
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;

            if (_context.TodoItems.Count() <= 0)
            {
                _context.TodoItems.Add(new TodoItem { Name = "To do item 1" });
                _context.TodoItems.Add(new TodoItem { Name = "To do item 2" });
                _context.TodoItems.Add(new TodoItem { Name = "To do item 3" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<TodoItem>> GetAll()
        {
            return _context.TodoItems.ToList();
        }

        [HttpGet("{id}", Name ="GetTodo")]
        public ActionResult<TodoItem> GetTodo(long id)
        {
            var result = _context.TodoItems.Find(id);

            if (result == null)
            {
                return NotFound(); 
            }

            return result;
        }

        [HttpPost]
        public IActionResult Create([FromBody] TodoItem item)
        {
            _context.TodoItems.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetTodo", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] TodoItem item)
        {
            var todo = _context.TodoItems.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            todo.IsComplete = item.IsComplete;
            todo.Name = item.Name;

            _context.TodoItems.Update(todo);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var todo = _context.TodoItems.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(todo);
            _context.SaveChanges();
            return NoContent();
        }
    }
}

namespace TodoAPI.Controllers.V2
{
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : Controller
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;

            if (_context.TodoItems.Count() <= 0)
            {
                _context.TodoItems.Add(new TodoItem { Name = "To do item 1" });
                _context.TodoItems.Add(new TodoItem { Name = "To do item 2" });
                _context.TodoItems.Add(new TodoItem { Name = "To do item 3" });
                _context.TodoItems.Add(new TodoItem { Name = "To do item 4" });
                _context.TodoItems.Add(new TodoItem { Name = "To do item 5" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<TodoItem>> GetAll()
        {
            return _context.TodoItems.ToList();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public ActionResult<TodoItem> GetTodo(long id)
        {
            var result = _context.TodoItems.Find(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet]
        [Route("/Kam")]
        public ActionResult<string> Kam()
        {
            return "Kam";
        }

        [HttpPost]
        public IActionResult Create([FromBody] TodoItem item)
        {
            _context.TodoItems.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetTodo", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, TodoItem item)
        {
            var todo = _context.TodoItems.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            todo.IsComplete = item.IsComplete;
            todo.Name = item.Name;

            _context.TodoItems.Update(todo);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var todo = _context.TodoItems.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(todo);
            _context.SaveChanges();
            return NoContent();
        }
    }
}

namespace TodoAPI.Controllers.V3
{
    [ApiVersion("3.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : Controller
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;

            if (_context.TodoItems.Count() <= 0)
            {
                _context.TodoItems.Add(new TodoItem { Name = "To do item 1" });
                _context.TodoItems.Add(new TodoItem { Name = "To do item 2" });
                _context.TodoItems.Add(new TodoItem { Name = "To do item 3" });
                _context.TodoItems.Add(new TodoItem { Name = "To do item 4" });
                _context.TodoItems.Add(new TodoItem { Name = "To do item 5" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<TodoItem>> GetAll()
        {
            return _context.TodoItems.ToList();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public ActionResult<TodoItem> GetTodo(long id)
        {
            var result = _context.TodoItems.Find(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet(Name = "Kam")]
        public ActionResult<string> Kam()
        {
            return "Kam";
        }

        [HttpPost]
        public IActionResult Create([FromBody] TodoItem item)
        {
            _context.TodoItems.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetTodo", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] TodoItem item)
        {
            var todo = _context.TodoItems.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            todo.IsComplete = item.IsComplete;
            todo.Name = item.Name;

            _context.TodoItems.Update(todo);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var todo = _context.TodoItems.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(todo);
            _context.SaveChanges();
            return NoContent();
        }
    }
}