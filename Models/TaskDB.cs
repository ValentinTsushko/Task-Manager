using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Task_Manager.Models
{
    public class TaskDBContext : DbContext
    {
        public TaskDBContext(DbContextOptions<TaskDBContext> options) : base(options) { }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}
