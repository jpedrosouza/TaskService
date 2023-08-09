using Microsoft.EntityFrameworkCore;
using TaskService.Data.Map;
using TaskService.Models;

namespace TaskService.Data
{
    public class TaskServiceDbContext: DbContext
    {
        public TaskServiceDbContext(DbContextOptions<TaskServiceDbContext> options) : base(options)
        {
        }

        public DbSet<TaskModel> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new TaskMap());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
