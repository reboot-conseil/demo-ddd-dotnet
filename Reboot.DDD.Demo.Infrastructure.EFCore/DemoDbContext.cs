using Microsoft.EntityFrameworkCore;
using Reboot.DDD.Demo.Domain.Entities;

namespace Reboot.DDD.Demo.Infrastructure.EFCore;

public class DemoDbContext(DbContextOptions<DemoDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasKey(user => user.Id);
    }
}
