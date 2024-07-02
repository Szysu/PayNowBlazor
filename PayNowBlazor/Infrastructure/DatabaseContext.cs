using Microsoft.EntityFrameworkCore;
using PayNowBlazor.Infrastructure.Entities;

namespace PayNowBlazor.Infrastructure;

public partial class DatabaseContext : DbContext
{
    private const string ConnectionString = "Data Source=paynow.db";

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Maintenance> Maintenances { get; set; }
    public DbSet<Rental> Rentals { get; set; }
    public DbSet<Scooter> Scooters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlite(ConnectionString, b => b.UseNetTopologySuite());
}