using Invelock_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Invelock_API.Data;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options){}
    public DbSet<Funcionario> Funcionarios { get; set; }
}

