using System;
using System.Collections.Generic;
using System.Text;
using ChuckSwapiC.Application.Features.IntegrationQueries.DataObjects;

namespace ChuckSwapiC.Integration.Adapters.ChuckNorrisAPI.DataObject
{
    public class ChuckNorrisSearchResponse
    {
        public int Total { get; set; }
        public List<ChuckNorrisSearchResult> Result { get; set; }
    }
}
