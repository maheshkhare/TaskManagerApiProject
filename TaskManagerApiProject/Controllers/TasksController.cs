using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagerApiProject.Data;
using TaskManagerApiProject.Models;

namespace TaskManagerApiProject.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class TasksController : ControllerBase
        {
            private readonly TaskContext _context;

            public TasksController(TaskContext context)
            {
                _context = context;
            }

            // GET: api/tasks
            [HttpGet]
            public async Task<ActionResult<IEnumerable<TaskModel>>> GetTasks()
            {
                return await _context.Tasks.ToListAsync();
            }

            // GET: api/tasks/{id}
            [HttpGet("{id}")]
            public async Task<ActionResult<TaskModel>> GetTask(int id)
            {
                var task = await _context.Tasks.FindAsync(id);
                if (task == null)
                    return NotFound(new { error = "Task not found" });

                return task;
            }

            // POST: api/tasks
            [HttpPost]
            public async Task<ActionResult<TaskModel>> CreateTask(TaskModel task)
            {
                if (string.IsNullOrWhiteSpace(task.Title))
                    return BadRequest(new { error = "Title is required" });

                _context.Tasks.Add(task);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetTask), new { id = task.Id }, task);
            }

           
        }
}
