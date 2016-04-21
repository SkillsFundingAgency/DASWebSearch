﻿namespace Sfa.Das.ApplicationServices
{
    using System.Collections.Generic;
    using Eds.Das.Core.Logging;
    using Sfa.Das.ApplicationServices.Models;

    public sealed class ApprenticeshipSearchService : IApprenticeshipSearchService
    {
        private readonly ISearchProvider _searchProvider;
        private readonly ILog _logger;

        public ApprenticeshipSearchService(ISearchProvider searchProvider, ILog logger)
        {
            _searchProvider = searchProvider;
            _logger = logger;
        }

        public ApprenticeshipSearchResults SearchByKeyword(string keywords, int skip, int take)
        {
            _logger.Info($"Apprenticeship Keyword Search: {keywords}", new Dictionary<string, object> { { "keywords", keywords.Split(' ') } });

            var takeElements = take == 0 ? 1000 : take;
            var results = _searchProvider.SearchByKeyword(keywords, skip, takeElements, ApprenticeshipSearchSortBy.StandardsFirst);

            return results;
        }
    }
}