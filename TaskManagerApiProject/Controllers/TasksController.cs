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

            // PUT: api/tasks/{id}
            [HttpPut("{id}")]
            public async Task<IActionResult> UpdateTask(int id, TaskModel updatedTask)
            {
                if (id != updatedTask.Id)
                    return BadRequest(new { error = "ID mismatch" });

                if (string.IsNullOrWhiteSpace(updatedTask.Title))
                    return BadRequest(new { error = "Title is required" });

                var task = await _context.Tasks.FindAsync(id);
                if (task == null)
                    return NotFound(new { error = "Task not found" });

                task.Title = updatedTask.Title;
                task.Description = updatedTask.Description;
                task.DueDate = updatedTask.DueDate;
                task.IsComplete = updatedTask.IsComplete;

                await _context.SaveChangesAsync();

                return Ok(task);
            }

            // DELETE: api/tasks/{id}
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteTask(int id)
            {
                var task = await _context.Tasks.FindAsync(id);
                if (task == null)
                    return NotFound(new { error = "Task not found" });

                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();

                return NoContent();
            }
        }
}
