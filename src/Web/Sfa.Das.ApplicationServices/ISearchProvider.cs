﻿using Sfa.Das.ApplicationServices.Models;
using Sfa.Eds.Das.Core.Domain.Model;

namespace Sfa.Das.ApplicationServices
{
    public interface ISearchProvider
    {
        ApprenticeshipSearchResults SearchByKeyword(string keywords, int skip, int take);

        SearchResult<StandardProviderSearchResultsItem> SearchByLocation(int standardId, Coordinate testCoordinates);
    }
}
