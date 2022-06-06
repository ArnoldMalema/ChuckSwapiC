using System;
using System.Collections.Generic;
using System.Text;
using ChuckSwapiC.Application.Features.IntegrationQueries.DataObjects;

namespace ChuckSwapiC.Integration.Adapters.StarWarsAPI.DataObject
{
    public class SwPeopleResponse
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<SwPeople> Results { get; set; }
    }
}
