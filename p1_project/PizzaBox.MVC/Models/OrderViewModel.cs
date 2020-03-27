using System.Collections.Generic;

namespace PizzaBox.MVC.Models
{
  public class OrderViewModel
  {
    public string Crust { get; set; }
    public List<string> Orders { get; set; } = new List<string>();
    public int Quantity { get; set; }
    public string Size { get; set; }
    public List<string> Toppings { get; set; } = new List<string>();
    public List<string> CrustList { get; set; } = new List<string> { "a", "b", "c" };
    public List<string> SizeList { get; set; } = new List<string> { "1", "2", "3" };
    public List<string> ToppingList { get; set; } = new List<string> { "@", "#", "%" };
  }
}
