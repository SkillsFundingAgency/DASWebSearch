﻿namespace Sfa.Das.Sas.Infrastructure.Providers
{
    using Sfa.Das.Sas.ApplicationServices;
    using Sfa.Das.Sas.ApplicationServices.Models;
    using Sfa.Das.Sas.Infrastructure.Mapping;
    using SFA.DAS.Apprenticeships.Api.Client;
    using System.Collections.Generic;

    public class ApprenticeshipsSearchApiProvider : IApprenticeshipSearchProvider
    {
        private readonly IApprenticeshipProgrammeApiClient _apprenticeshipProgrammeApiClient;
        private readonly IApprenticeshipSearchResultsMapping _apprenticeshipSearchResultsMapping;
        public ApprenticeshipsSearchApiProvider(IApprenticeshipProgrammeApiClient apprenticeshipProgrammeApiClient, IApprenticeshipSearchResultsMapping apprenticeshipSearchResultsMapping)
        {
            _apprenticeshipProgrammeApiClient = apprenticeshipProgrammeApiClient;
            _apprenticeshipSearchResultsMapping = apprenticeshipSearchResultsMapping;
        }

        public ApprenticeshipSearchResults SearchByKeyword(string keywords, int page, int take, int order, List<int> selectedLevels)
        {
            var results = _apprenticeshipSearchResultsMapping.Map(_apprenticeshipProgrammeApiClient.Search(keywords, page));
            return results;
        }
    }
}