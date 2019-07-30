namespace ToDoList.Data
{
    using Microsoft.EntityFrameworkCore;
    using ToDoList.Models;

    public class TasksDbContext : DbContext
    {
        private const string ConnectionString = @"Server=.\SQLEXPRESS01;Database=ToDoListDb; Integrated Security=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public virtual DbSet<Task> Tasks { get; set; }



    }
}
