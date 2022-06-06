using System;
using System.Collections.Generic;
using System.Text;
using ChuckSwapiC.Application.Utilities.Http;
using ChuckSwapiC.Application.Utilities.Settings;
using ChuckSwapiC.Integration.Adapters.ChuckNorrisAPI;
using ChuckSwapiC.Integration.Adapters.StarWarsAPI;
using Moq;

namespace ChuckSwapiC.Integration.MockFactory
{
    public class MockFactory
    {

        public static ChuckNorrisIntegrator GetChuckNorrisIntegrator()
        {
            return new ChuckNorrisIntegrator(new HttpAdapter(), new ApplicationSettings() {ChuckNorrisUrl = "https://api.chucknorris.io"});
        }

        public static StarWarsIntegrator GetStarWarsIntegrator()
        {
            return new StarWarsIntegrator(new HttpAdapter(), new ApplicationSettings() {StarWarsUrl = "https://swapi.dev/api"});
        }
    }
}
