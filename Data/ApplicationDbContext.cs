using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using To_Do_List;

namespace ToDoList.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) //representa o nosso banoc de dados em SQLite
        : base(options)
    {
    }
    public DbSet<Todo> Todos { get; set; } //representa a tabela em SQLite
}
