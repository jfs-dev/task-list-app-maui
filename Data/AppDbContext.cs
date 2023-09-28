using Microsoft.EntityFrameworkCore;
using task_list_app_maui.Models;

namespace task_list_app_maui.Data;

public class AppDbContext : DbContext
{
    public DbSet<Tarefa> Tarefas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("task-list-app-maui");
    }    
}
