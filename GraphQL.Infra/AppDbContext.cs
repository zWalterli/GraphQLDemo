using GraphQL.Infra.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Infra;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=../GraphQL.API/app.db");
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TaskItem>(entity =>
        {
            entity.ToTable("Tasks");
            entity.HasKey(t => t.Id);
            entity.Property(t => t.Title).IsRequired();
            entity.Property(t => t.Description).IsRequired();
        });
        modelBuilder.Entity<TaskItem>().ToTable("Tasks");
    }

    public DbSet<TaskItem> Tasks { get; set; }
}