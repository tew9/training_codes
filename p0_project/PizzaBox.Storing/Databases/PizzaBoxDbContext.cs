using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Databases
{
  public class PizzaBoxDbContext : DbContext
  {
    public DbSet<Pizza> Pizzas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("server=localhost;database=pizzaboxdb;user id=sa;password=Password12345;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Pizza>().HasKey(p => p.PizzaId);

      builder.Entity<Pizza>().HasData(new Pizza[]
      {
        new Pizza(){ PizzaId = 1},
        new Pizza(){ PizzaId = 2}
      });
    }
  }
}
