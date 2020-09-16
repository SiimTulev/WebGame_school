using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebGame
{
    public class Program
    {
        public static void Main (string[] args)
        {
            CreateWebHostBuilder (args).Build ().Run ();

        }

        public static IWebHostBuilder CreateWebHostBuilder (string[] args) =>
            WebHost.CreateDefaultBuilder (args)
            .UseStartup<Startup> ()
            .UseUrls ("http://localhost:5003");

    }

    //    public static void Main(string[] args)
    //    {
    //        CreateHostBuilder(args).Build().Run();
    //    }

    //    public static IHostBuilder CreateHostBuilder(string[] args) =>
    //        Host.CreateDefaultBuilder(args)
    //            .ConfigureWebHostDefaults(webBuilder =>
    //            {
    //                //webBuilder.UseSetting(WebHostDefaults.DetailedErrorsKey, "true");
    //                webBuilder.UseStartup<Startup>();
    //            });
    //}
}