using System;
using System.Collections.Generic;
using System.Text;
using ChuckSwapiC.Application.Utilities.Http;
using ChuckSwapiC.Application.Utilities.Settings;
using ChuckSwapiC.Integration.Adapters.ChuckNorrisAPI;
using Moq;
using NUnit.Framework;
using MockFactory = ChuckSwapiC.Integration.MockFactory.MockFactory;

namespace ChuckSwapiC.Tests.IntegrationTests
{
    [TestFixture]
    public class IntegratorTests
    {

        [TestCase]
        public void GetChuckNorrisAPICategoriesIsNotNull()
        {

            //Setup
            var mock = MockFactory.GetChuckNorrisIntegrator();

            //Arrange
            var result = mock.GetCategories();

            //Assert
            Assert.IsNotNull(result);

        }
        [TestCase]
        public void GetSwPeopleIsNotNull()
        {

            //Setup
            var mock = MockFactory.GetStarWarsIntegrator();

            //Arrange
            var result = mock.GetAllPeople();

            //Assert
            Assert.IsNotNull(result);

        }
        [TestCase("someValue")]
        public void ChuckNorrisAPISearchIsNotNull(string tag)
        {

            //Setup
            var mock = MockFactory.GetChuckNorrisIntegrator();

            //Arrange
            var result = mock.Search(tag);

            //Assert
            Assert.IsNotNull(result);

        }

        [TestCase("someValue")]
        public void StarWarsAPISearchIsNotNull(string tag)
        {

            //Setup
            var mock = MockFactory.GetStarWarsIntegrator();

            //Arrange
            var result = mock.SearchPeople(tag);

            //Assert
            Assert.IsNotNull(result);

        }
    }
}
