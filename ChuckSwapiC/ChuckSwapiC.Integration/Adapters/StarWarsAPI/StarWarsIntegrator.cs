using System;
using System.Collections.Generic;
using System.Text;
using ChuckSwapiC.Application.Features.IntegrationQueries.Adapters;
using ChuckSwapiC.Application.Features.IntegrationQueries.DataObjects;
using ChuckSwapiC.Application.Utilities.Http;
using ChuckSwapiC.Application.Utilities.Settings;
using ChuckSwapiC.Integration.Adapters.StarWarsAPI.DataObject;

namespace ChuckSwapiC.Integration.Adapters.StarWarsAPI
{
    public class StarWarsIntegrator : IStarWarsAdapter
    {
        private readonly IHttpAdapter httpAdapter;
        private readonly ApplicationSettings applicationSettings;


        public StarWarsIntegrator(IHttpAdapter httpAdapter, ApplicationSettings applicationSettings)
        {
            this.httpAdapter = httpAdapter;
            this.applicationSettings = applicationSettings;
        }

        public List<SwPeople> GetAllPeople()
        {
            var url = $"{applicationSettings.StarWarsUrl}/people";

            return httpAdapter.Get<SwPeopleResponse>(url, false, null, true).Results;
        }

        public List<SwPeople> SearchPeople(string tag)
        {
            var url = $"{applicationSettings.StarWarsUrl}/people/?{tag}";

            return httpAdapter.Get<SwPeopleResponse>(url, false, null, true).Results;

        }
    }
}
