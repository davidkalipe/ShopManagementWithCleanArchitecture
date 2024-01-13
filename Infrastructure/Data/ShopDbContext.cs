using Domain.Clients;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ShopDbContext : DbContext
{
    public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options){}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql("");
        }
    }

    public DbSet<Client> Clients { get; set; }

    
}