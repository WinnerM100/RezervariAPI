

using Microsoft.EntityFrameworkCore;
using RezervariAPI.AccessLayer.Models;
using RezervariAPI.Models;

namespace RezervariAPI.AccessLayer.Context;

public class RezervariContext : DbContext
{
    public DbSet<Rezervare> Rezervari { get; set; }

    private SqlConnector sqlConnector;

    public RezervariContext(SqlConnector sqlConnector)
    {
        this.sqlConnector = sqlConnector;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {   
        optionsBuilder.UseSqlServer(sqlConnector.DbConnection.ConnectionString);
        optionsBuilder.EnableSensitiveDataLogging();
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Debug);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Rezervare>().ToTable("Rezervare");
    }
}