using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TaskManagerApiProject.Models;

namespace TaskManagerApiProject.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }

        public DbSet<TaskModel> Tasks { get; set; }
    }
}
