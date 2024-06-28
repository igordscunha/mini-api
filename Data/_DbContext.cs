using Microsoft.EntityFrameworkCore;
using MiniApi.Models;

namespace MiniApi.Data;

public class _DbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlite("DataSource=jogadores.db;Cache=Shared");
    }

    public DbSet<Jogador> Jogadores { get; set; }
}
