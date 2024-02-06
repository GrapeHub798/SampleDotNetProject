namespace DotNetSample.Infrastructure.Data;

using DotNetSample.Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class AppDbContext: DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<User> Users { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>()
            .HasIndex(u => u.EmailAddress)
            .IsUnique();
    }
}