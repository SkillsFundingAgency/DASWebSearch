﻿using Sfa.Das.FatApi.Client.Model;

namespace Sfa.Das.Sas.Infrastructure.Mapping
{
    using Sfa.Das.Sas.ApplicationServices.Models;

    public interface ISearchResultsMapping
    {
        SearchResult<ProviderSearchResultItem> Map(SFADASApprenticeshipsApiTypesV3ProviderApprenticeshipLocationSearchResult document);
    }
}