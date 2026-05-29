
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using TodoApi.Models;


namespace TodoApi.AppDbContext
{
    public class Context : DbContext
    {
        public virtual DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"");
        }
    }
}
