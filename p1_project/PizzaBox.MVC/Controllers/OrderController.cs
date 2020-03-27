using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaBox.MVC.Models;

namespace PizzaBox.MVC.Controllers
{
  public class OrderController : Controller
  {
    private readonly ILogger<OrderController> _logger;
    private static readonly List<OrderViewModel> orders = new List<OrderViewModel>();

    public OrderController(ILogger<OrderController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
      return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
      return View(new OrderViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(OrderViewModel model)
    {
      if (!ModelState.IsValid)
      {
        return View(model);
      }

      orders.Add(model);

      var newModel = new OrderViewModel();

      foreach (var item in orders)
      {
        newModel.Orders.Add(orders.IndexOf(item).ToString());
      }

      return View(newModel);
    }
  }
}
