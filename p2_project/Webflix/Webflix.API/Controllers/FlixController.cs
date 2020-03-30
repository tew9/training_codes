using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Webflix.API.Models;

namespace Webflix.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class FlixController : ControllerBase
  {
    private static readonly List<FlixModel> _fml = new List<FlixModel>()
    {
      new FlixModel() { Title = "Watchmen" },
      new FlixModel() { Title = "Forest Gump" }
    };

    private readonly ILogger<FlixController> _logger;

    public FlixController(ILogger<FlixController> logger)
    {
      _logger = logger;
    }

    public IActionResult Get()
    {
      var res = (new HttpClient()).GetAsync("https://swapi.co/").GetAwaiter().GetResult();
      var films = res.Content.ReadAsStringAsync();
      return Ok(_fml);
    }
  }
}
