
using System.IO;
using Microsoft.AspNetCore.Hosting;
// using System;
// using OrderTracker.Models;
// using System.Collections.Generic;

namespace OrderTracker
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}

