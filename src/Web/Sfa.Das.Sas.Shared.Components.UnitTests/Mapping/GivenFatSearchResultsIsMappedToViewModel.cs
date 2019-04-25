﻿using System.Collections.Generic;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using Sfa.Das.Sas.ApplicationServices.Models;
using Sfa.Das.Sas.Shared.Components.Domain.Interfaces;
using Sfa.Das.Sas.Shared.Components.Mapping;
using Sfa.Das.Sas.Shared.Components.ViewComponents.Fat;

namespace Sfa.Das.Sas.Shared.Components.UnitTests.Mapping
{
    [TestFixture]
    public class GivenFatSearchResultsIsMappedToViewModel
    {
        private FatSearchResultsViewModelMapper _sut;
        private ApprenticeshipSearchResults _itemToMap;
        private Mock<ICssViewModel> _cssClassMock;
        private Mock<IFatSearchResultsItemViewModelMapper> _fatSearchItemMapperMock;

        [SetUp]
        public void Setup()
        {

            _fatSearchItemMapperMock = new Mock<IFatSearchResultsItemViewModelMapper>(MockBehavior.Strict);

            _fatSearchItemMapperMock.Setup(s => s.Map(It.IsAny<ApprenticeshipSearchResultsItem>(), It.IsAny<ICssViewModel>())).Returns(new FatSearchResultsItemViewModel(){Title = "Apprenticeship"});

            _sut = new FatSearchResultsViewModelMapper(_fatSearchItemMapperMock.Object);

            _cssClassMock = new Mock<ICssViewModel>();

            _itemToMap = new ApprenticeshipSearchResults()
            {
                ActualPage = 1,
                LastPage = 20,
                SearchTerm = "Apprenticeship",
                ResultsToTake = 20,
                TotalResults = 400,
                SortOrder = "1",
                Results = new List<ApprenticeshipSearchResultsItem>()
                {
                    new ApprenticeshipSearchResultsItem(){Title = "apprenticeship"},
                    new ApprenticeshipSearchResultsItem(){Title = "apprenticeship"}
                }
            };
        }

        [Test]
        public void When_Mapping_Then_FatSearchResultsItemViewModel_Is_Returned()
        {
          var result =  _sut.Map(_itemToMap, _cssClassMock.Object);

          result.Should().BeOfType<FatSearchResultsViewModel>();
          result.Should().NotBeNull();
        }

        [Test]
        public void When_Mapping_Then_Items_Are_Mapped()
        {
            var result = _sut.Map(_itemToMap, _cssClassMock.Object);

            result.SearchQuery.Page.Should().Be(_itemToMap.ActualPage);
            result.SearchQuery.Keywords.Should().Be(_itemToMap.SearchTerm);
            result.LastPage.Should().Be(_itemToMap.LastPage);
            result.SearchQuery.ResultsToTake.Should().Be(_itemToMap.ResultsToTake);
            result.SearchResults.Should().HaveSameCount(_itemToMap.Results);
            result.SearchQuery.SortOrder.Should().Be(int.Parse(_itemToMap.SortOrder));
            result.TotalResults.Should().Be(_itemToMap.TotalResults);
        }

        [Test]
        public void When_Mapping_And_SortOrder_Is_Null_Then_Items_Are_Mapped_And_sortOrder_Is_Zero()
        {
            _itemToMap.SortOrder = null;

            var result = _sut.Map(_itemToMap, _cssClassMock.Object);

            result.SearchQuery.Page.Should().Be(_itemToMap.ActualPage);
            result.SearchQuery.Keywords.Should().Be(_itemToMap.SearchTerm);
            result.LastPage.Should().Be(_itemToMap.LastPage);
            result.SearchQuery.ResultsToTake.Should().Be(_itemToMap.ResultsToTake);
            result.SearchResults.Should().HaveSameCount(_itemToMap.Results);
            result.SearchQuery.SortOrder.Should().Be(0);
            result.TotalResults.Should().Be(_itemToMap.TotalResults);
        }

    }
}
