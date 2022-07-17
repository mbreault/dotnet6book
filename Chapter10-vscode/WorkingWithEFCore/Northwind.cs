using Microsoft.EntityFrameworkCore;
using static System.Console;
namespace Packt.Shared;
public class Northwind : DbContext
{
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
    protected override void OnModelCreating(
    ModelBuilder modelBuilder)
  {
    // global filter for discontinued products
    modelBuilder.Entity<Product>()
      .HasQueryFilter(p => !p.Discontinued);

    // example of using Fluent API instead of attributes
    // to limit the length of a category name to 15
    modelBuilder.Entity<Category>()
      .Property(category => category.CategoryName)
      .IsRequired() // NOT NULL
      .HasMaxLength(15);
  }
}