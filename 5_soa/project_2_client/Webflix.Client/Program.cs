using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Webflix.Client
{
  class Program
  {
    static void Main(string[] args)
    {
      HttpClient client = new HttpClient();

      var res = client.GetAsync("http://localhost:5000/movie").GetAwaiter().GetResult();

      System.Console.WriteLine(res);

      Console.ReadLine();
    }
  }
}
