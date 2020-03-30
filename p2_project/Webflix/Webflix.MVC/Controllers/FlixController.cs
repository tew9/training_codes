using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Webflix.MVC.Models;

namespace Webflix.MVC.Controllers
{
  public class FlixController : Controller
  {
    private readonly HttpClient _http = new HttpClient();

    private readonly ILogger<HomeController> _logger;

    public FlixController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      var res = _http.GetAsync("http://api/flix").GetAwaiter().GetResult();
      var films = JsonConvert.DeserializeObject<List<FlixViewModel>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());

      return View(films);
    }
  }
}
