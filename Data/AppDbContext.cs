using Microsoft.EntityFrameworkCore;
using MeuProjetoSQLite.Models;

namespace MeuProjetoSQLite.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {
    }

    public DbSet<Produto> Produtos { get; set; }
}