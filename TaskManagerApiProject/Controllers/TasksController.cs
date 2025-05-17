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

          
        }
}
