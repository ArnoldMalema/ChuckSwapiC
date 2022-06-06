using System;
using System.Collections.Generic;
using System.Text;
using ChuckSwapiC.Application.Features.IntegrationQueries.DataObjects;

namespace ChuckSwapiC.Application.Features.IntegrationQueries.Adapters
{
    public interface IChuckNorrisAdapter
    {
        List<string> GetCategories();
        List<ChuckNorrisSearchResult> Search(string tag);
    }
}
