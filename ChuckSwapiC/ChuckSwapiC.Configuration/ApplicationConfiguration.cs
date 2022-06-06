using System;
using System.IO;
using ChuckSwapiC.Application.Utilities.Settings;
using ChuckSwapiC.Configuration.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;

namespace ChuckSwapiC.Configuration
{
    public class ApplicationConfiguration
    {
        private const string ServiceName = "ChuckSwapiC";

        private void SetupDependencies(IServiceCollection serviceCollection)
        {
            //Todo
        }

        public void RegisterServices(IConfiguration configuration, IServiceCollection serviceCollection)
        {
            serviceCollection.Configure<ApplicationSettings>(configuration.GetSection("ApplicationSettings"));

            SetupDependencies(serviceCollection);
            var applicationSettings = new ApplicationSettings();
            configuration.GetSection("ApplicationSettings").Bind(applicationSettings);
            serviceCollection.AddSingleton(applicationSettings);
            serviceCollection.AddHostedService<WebApiService>();

        }

        public void SetupLogging(ILoggingBuilder loggingBuilder)
        {
            loggingBuilder.AddSerilog(dispose: true);
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File($"{ServiceName}Log.txt",
                    rollingInterval: RollingInterval.Day,
                    rollOnFileSizeLimit: true,
                    fileSizeLimitBytes: 1024,
                    retainedFileCountLimit: 3,
                    restrictedToMinimumLevel: LogEventLevel.Debug)
                .WriteTo.Console(LogEventLevel.Information)
                .CreateLogger();
        }

        public void SetupAppSettings(IConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.SetBasePath(Directory.GetCurrentDirectory()).AddEnvironmentVariables();

            configurationBuilder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true)
                .AddJsonFile($"appsettings.dev.json", true)
                .AddEnvironmentVariables();
        }
    }
}
