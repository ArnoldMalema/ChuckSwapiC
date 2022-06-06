using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChuckSwapiC.Configuration;

namespace ChuckSwapiC.Web
{
    public class Program
    {
        private static ApplicationConfiguration applicationConfiguration;

        public static void Main(string[] args)
        {
            applicationConfiguration = new ApplicationConfiguration();
            var host = CreateHostBuilder(args);
            var build = host.Build();
            build.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging((context, builder) =>
                {
                    applicationConfiguration.SetupLogging(builder);
                })
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    applicationConfiguration.SetupAppSettings(config);
                })
                .ConfigureServices((context, collection) =>
                {
                    applicationConfiguration.RegisterServices(context.Configuration, collection);
                })
                .ConfigureWebHostDefaults(w =>
                {
                    w.UseStartup<Startup>();
                });
    }
    }
