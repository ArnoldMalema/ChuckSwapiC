using System;
using System.Collections.Generic;
using System.Text;
using ChuckSwapiC.Application.Features.IntegrationQueries.Adapters;

namespace ChuckSwapiC.Application.Features.IntegrationQueries
{
    public class IntegrationQueriesService
    {
        private readonly IChuckNorrisAdapter CnAdapter;
        private readonly IStarWarsAdapter SwAdapter;

        public IntegrationQueriesService(IChuckNorrisAdapter cnAdapter, IStarWarsAdapter swAdapter)
        {
            CnAdapter = cnAdapter;
            SwAdapter = swAdapter;
        }

    }
}
