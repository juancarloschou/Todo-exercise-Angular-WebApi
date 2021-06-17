using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public interface ITodoContext
    {
        DbSet<TodoItem> TodoItems { get; set; }
    }

    public class TodoContext : DbContext, ITodoContext
    {
        public TodoContext()
        {
        }

        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //esto ha sido necesario para la creacion inicial de las tablas con "dotnet ef database update"
        //    //https://github.com/aspnet/EntityFrameworkCore/issues/9027
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer(@"Data Source=AJU-PC;Initial Catalog=Todo;Integrated Security=True");
        //    }
        //}
    }
}
