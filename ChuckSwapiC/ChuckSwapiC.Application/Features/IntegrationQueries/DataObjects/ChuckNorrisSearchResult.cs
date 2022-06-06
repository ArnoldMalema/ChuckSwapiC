using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckSwapiC.Application.Features.IntegrationQueries.DataObjects
{
    public class ChuckNorrisSearchResult
    {
        public List<string> Categories { get; set; }
        public string CreatedAt { get; set; }
        public string IconUrl { get; set; }
        public string Id { get; set; }
        public string UpdatedAt { get; set; }
        public string Url { get; set; }
        public string Value { get; set; }
    }
}
