using System;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;

namespace ConsoleToApi
{
    class program
    {
        static void Main(string[] args)
        {

        }
        public static IHostBuilder CreateHostBuilder()
        {
          return  Host.CreateDefaultBuilder().ConfigureWebHostDefaults(webBuilder =>
            {
                WebHost.UseStartup<Startup>();
            });
        }

    }
}
