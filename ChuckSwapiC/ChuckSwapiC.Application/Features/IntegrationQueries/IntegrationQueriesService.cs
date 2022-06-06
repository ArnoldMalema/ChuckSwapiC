using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ChuckSwapiC.Application.Features.IntegrationQueries.Adapters;
using ChuckSwapiC.Application.Utilities.DataObjects;

namespace ChuckSwapiC.Application.Features.IntegrationQueries
{
    public class IntegrationQueriesService
    {
        private readonly IChuckNorrisAdapter cnAdapter;
        private readonly IStarWarsAdapter swAdapter;

        public IntegrationQueriesService(IChuckNorrisAdapter cnAdapter, IStarWarsAdapter swAdapter)
        {
            this.cnAdapter = cnAdapter;
            this.swAdapter = swAdapter;
        }
        public ResultBase GetCnCategories()
        {
            return new ResultBase(true, "", cnAdapter.GetCategories());
        }
        public ResultBase GetJokeFromRandomCategory(string category)
        {
            return new ResultBase(true, "", cnAdapter.GetRandomJokeFromCategory(category));
        }

        public ResultBase GetAllSwPeople()
        {
            return new ResultBase(true, "", swAdapter.GetAllPeople());
        }
        public ResultBase Search(string tag)
        {
            var cnSearch = new ResultBase(true, "Source: Chuck Norris Api", cnAdapter.Search(tag));
            var swSearch = new ResultBase(true, "Source: Star Wars Api", swAdapter.SearchPeople(tag));
            return new ResultBase(true, "See payload for details", new List<object>(){cnSearch, swSearch});
        }
    }
}
