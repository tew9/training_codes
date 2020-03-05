using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client
{
  internal class Program
  {
    private static readonly PizzaRepository _pr = new PizzaRepository();

    private static void Main(string[] args)
    {
      GetAllPizzas();
    }

    private static void GetAllPizzas()
    {
      Pizza p1 = new Pizza();
      Pizza p2 = new Pizza();
      foreach (var p in _pr.Get())
      {
        Console.WriteLine(p.PizzaId);
      }
    }
  }
}
