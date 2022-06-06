using System;
using System.IO;
using ChuckSwapiC.Application.Features.IntegrationQueries;
using ChuckSwapiC.Application.Features.IntegrationQueries.Adapters;
using ChuckSwapiC.Application.Utilities.Http;
using ChuckSwapiC.Application.Utilities.Settings;
using ChuckSwapiC.Configuration.Services;
using ChuckSwapiC.Integration.Adapters.ChuckNorrisAPI;
using ChuckSwapiC.Integration.Adapters.StarWarsAPI;
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
            serviceCollection.AddScoped<IHttpAdapter, HttpAdapter>();
            serviceCollection.AddScoped<IChuckNorrisAdapter, ChuckNorrisIntegrator>();
            serviceCollection.AddScoped<IStarWarsAdapter, StarWarsIntegrator>();
            serviceCollection.AddScoped<IntegrationQueriesService>();

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
