﻿namespace Sfa.Das.ApplicationServices.UnitTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Moq;

    using NUnit.Framework;

    using Sfa.Das.ApplicationServices.Exceptions;
    using Sfa.Das.ApplicationServices.Models;
    using Sfa.Eds.Das.Core.Domain.Model;
    using Sfa.Eds.Das.Core.Domain.Services;
    using Sfa.Eds.Das.Core.Logging;

    [TestFixture]
    public class ProviderSearchServiceTests
    {
        [TestCase("")]
        [TestCase(null)]
        public async Task SearchByPostCodeShouldIdicateIfANullOrEmptyPostCodeIsPassed(string postcode)
        {
            var service = new ProviderSearchService(null, null, null, null);

            var result = await service.SearchByPostCode(123, postcode);

            Assert.That(result.PostCodeMissing, Is.True);
        }

        [TestCase("")]
        [TestCase("ABC 123")]
        public async Task SearchByPostCodeShouldAlwaysReturnTheStandardId(string postcode)
        {
            const int testStandardId = 123;
            var mockSearchProvider = CreateMockSearchProvider();
            var mockapprenticeshipRepository = CreateMockapprenticeshipRepository();
            var mockPostCodeLookup = CreateMockPostCodeLookup();
            var mockLogger = new Mock<ILog>() { DefaultValue = DefaultValue.Mock };
            var service = new ProviderSearchService(mockSearchProvider.Object, mockapprenticeshipRepository.Object, mockPostCodeLookup.Object, mockLogger.Object);

            var result = await service.SearchByPostCode(testStandardId, postcode);

            Assert.That(result.StandardId, Is.EqualTo(testStandardId));
        }

        [Test]
        public async Task SearchByPostCodeShouldSearchForProviderByLatLongAndStandardId()
        {
            const int testStandardId = 123;
            const string testPostCode = "AS3 4AA";
            var testCoordinates = new Coordinate { Lat = 52.1234, Lon = 1.3445 };
            var stubSearchResults = new List<StandardProviderSearchResultsItem> { new StandardProviderSearchResultsItem(), new StandardProviderSearchResultsItem() };
            var mockSearchProvider = CreateMockSearchProvider(stubSearchResults);
            var mockapprenticeshipRepository = CreateMockapprenticeshipRepository();
            var mockPostCodeLookup = CreateMockPostCodeLookup();
            mockPostCodeLookup.Setup(x => x.GetLatLongFromPostCode(It.IsAny<string>())).Returns(Task.FromResult(testCoordinates));

            var mockLogger = new Mock<ILog>() { DefaultValue = DefaultValue.Mock };
            var service = new ProviderSearchService(mockSearchProvider.Object, mockapprenticeshipRepository.Object, mockPostCodeLookup.Object, mockLogger.Object);

            var result = await service.SearchByPostCode(testStandardId, testPostCode);

            Assert.That(result.Hits, Is.EqualTo(stubSearchResults));

            mockPostCodeLookup.Verify(x => x.GetLatLongFromPostCode(testPostCode), Times.Once);
            mockSearchProvider.Verify(x => x.SearchByLocation(testStandardId, testCoordinates), Times.Once);
        }

        [Test]
        public async Task SearchByPostCodeShouldIncludeCountOfResults()
        {
            const long testTotalResults = 5;
            var mockSearchProvider = CreateMockSearchProvider(null, testTotalResults);
            var mockapprenticeshipRepository = CreateMockapprenticeshipRepository();
            var mockPostCodeLookup = CreateMockPostCodeLookup();

            var mockLogger = new Mock<ILog>() { DefaultValue = DefaultValue.Mock };
            var service = new ProviderSearchService(mockSearchProvider.Object, mockapprenticeshipRepository.Object, mockPostCodeLookup.Object, mockLogger.Object);

            var result = await service.SearchByPostCode(123, "AS2 3SS");

            Assert.That(result.TotalResults, Is.EqualTo(testTotalResults));
        }

        [Test]
        public async Task SearchByPostCodeShouldIncludeStandardName()
        {
            const string testTitle = "Test Title";
            var mockSearchProvider = CreateMockSearchProvider();
            var mockapprenticeshipRepository = new Mock<IApprenticeshipRepository>();
            mockapprenticeshipRepository.Setup(x => x.GetStandardById(It.IsAny<int>())).Returns(new Standard { Title = testTitle });
            var mockPostCodeLookup = CreateMockPostCodeLookup();

            var mockLogger = new Mock<ILog>() { DefaultValue = DefaultValue.Mock };
            var service = new ProviderSearchService(mockSearchProvider.Object, mockapprenticeshipRepository.Object, mockPostCodeLookup.Object, mockLogger.Object);

            var result = await service.SearchByPostCode(123, "AS3 4AS");

            Assert.That(result.StandardName, Is.EqualTo(testTitle));
        }

        [Test]
        public async Task SearchByPostCodeShouldIndicateThereWasAnErrorIfSearchThrowsAnException()
        {
            var mockSearchProvider = CreateMockSearchProvider();
            mockSearchProvider.Setup(x => x.SearchByLocation(It.IsAny<int>(), It.IsAny<Coordinate>())).Throws<SearchException>();
            var mockapprenticeshipRepository = new Mock<IApprenticeshipRepository>();
            var mockPostCodeLookup = CreateMockPostCodeLookup();

            var mockLogger = new Mock<ILog>() { DefaultValue = DefaultValue.Mock };
            var service = new ProviderSearchService(mockSearchProvider.Object, mockapprenticeshipRepository.Object, mockPostCodeLookup.Object, mockLogger.Object);

            var result = await service.SearchByPostCode(123, "AS3 4AS");

            Assert.That(result.HasError, Is.True);
        }

        private static Mock<ISearchProvider> CreateMockSearchProvider(List<StandardProviderSearchResultsItem> stubSearchResults, long totalHits = 0)
        {
            var searchResults = new SearchResult<StandardProviderSearchResultsItem> { Hits = stubSearchResults, Total = totalHits };

            var mockSearchProvider = new Mock<ISearchProvider>();
            mockSearchProvider.Setup(x => x.SearchByLocation(It.IsAny<int>(), It.IsAny<Coordinate>())).Returns(searchResults);

            return mockSearchProvider;
        }

        private static Mock<ISearchProvider> CreateMockSearchProvider()
        {
            return CreateMockSearchProvider(null);
        }

        private static Mock<IApprenticeshipRepository> CreateMockapprenticeshipRepository()
        {
            var mockapprenticeshipRepository = new Mock<IApprenticeshipRepository>();

            return mockapprenticeshipRepository;
        }

        private static Mock<ILookupLocations> CreateMockPostCodeLookup()
        {
            var testCoordinates = new Coordinate { Lat = 52.1234, Lon = 1.3445 };

            var mockPostCodeLookup = new Mock<ILookupLocations>();
            mockPostCodeLookup.Setup(x => x.GetLatLongFromPostCode(It.IsAny<string>())).Returns(Task.FromResult(testCoordinates));

            return mockPostCodeLookup;
        }
    }
}