using System;
using System.Collections.Generic;
using System.Text;
using ChuckSwapiC.Application.Features.IntegrationQueries.DataObjects;

namespace ChuckSwapiC.Application.Features.IntegrationQueries.Adapters
{
    public interface IStarWarsAdapter
    {
        List<SwPeople> GetAllPeople();
        List<SwPeople> SearchPeople(string tag);
    }
}
