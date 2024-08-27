using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using WebApplication7.Models;

namespace WebApplication7;

public class AppMyDbContext : DbContext
{
    public AppMyDbContext(DbContextOptions<AppMyDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Product> Products { get; set; }
}