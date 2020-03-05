using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repositories
{
  public class PizzaRepository
  {
    private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();

    public List<Pizza> Get()
    {
      return _db.Pizzas.ToList();
    }
  }
}
