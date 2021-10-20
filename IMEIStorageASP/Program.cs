using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMEIStorageASP
{
    public class Program
    {
        public static void Main(string[] args)
        {

           Service serv = new Service("http://dswork:5000", new System.Net.Http.HttpClient());


            //var m1 = serv.IMEIAsync("221");
           // var m2 = serv.IMEIAsync("222").Result;

            //var models = serv.IMEIAllAsync();

            CreateHostBuilder(args).Build().Run();

            

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
