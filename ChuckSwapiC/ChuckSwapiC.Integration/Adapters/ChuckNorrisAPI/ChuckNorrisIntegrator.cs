using System;
using System.Collections.Generic;
using System.Text;
using ChuckSwapiC.Application.Features.IntegrationQueries.Adapters;
using ChuckSwapiC.Application.Features.IntegrationQueries.DataObjects;
using ChuckSwapiC.Application.Utilities.Http;
using ChuckSwapiC.Application.Utilities.Settings;
using ChuckSwapiC.Integration.Adapters.ChuckNorrisAPI.DataObject;

namespace ChuckSwapiC.Integration.Adapters.ChuckNorrisAPI
{
    public class ChuckNorrisIntegrator : IChuckNorrisAdapter
    {
        private readonly IHttpAdapter httpAdapter;
        private readonly ApplicationSettings applicationSettings;

        public ChuckNorrisIntegrator(IHttpAdapter httpAdapter, ApplicationSettings applicationSettings)
        {
            this.httpAdapter = httpAdapter;
            this.applicationSettings = applicationSettings;
        }

        public List<string> GetCategories()
        {
            var url = $"{applicationSettings.ChuckNorrisUrl}/jokes/categories";

            return httpAdapter.Get<List<string>>(url, false, null, true);
        }

        public List<ChuckNorrisSearchResult> Search(string tag)
        {
            var url = $"{applicationSettings.StarWarsUrl}/jokes/search={tag}";

            return httpAdapter.Get<ChuckNorrisSearchResponse>(url, false, null, true).Result;
        }
    }
}
