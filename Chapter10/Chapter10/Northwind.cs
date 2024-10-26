using Microsoft.EntityFrameworkCore;
using Packt.Shared;

public class Northwind : DbContext
{
    // these properties map to tables in the database
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }
    protected override void OnConfiguring(
      DbContextOptionsBuilder optionsBuilder)
    { }
    protected override void OnModelCreating(
 ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Category>()
          .Property(category => category.CategoryName)
          .IsRequired() // NOT NULL
          .HasMaxLength(15);
        if (Database.ProviderName?.Contains("Sqlite") ?? false)
        {
            modelBuilder.Entity<Product>()
              .Property(product => product.Cost)
              .HasConversion<double>();
        }
    }
}