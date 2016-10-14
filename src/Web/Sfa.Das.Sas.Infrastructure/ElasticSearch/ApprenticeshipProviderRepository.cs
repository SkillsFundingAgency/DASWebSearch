﻿using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Nest;
using Sfa.Das.Sas.ApplicationServices.Models;
using Sfa.Das.Sas.Core.Configuration;
using Sfa.Das.Sas.Core.Domain.Model;
using Sfa.Das.Sas.Core.Domain.Services;
using Sfa.Das.Sas.Core.Logging;
using Sfa.Das.Sas.Infrastructure.Mapping;

namespace Sfa.Das.Sas.Infrastructure.Elasticsearch
{
    public sealed class ApprenticeshipProviderRepository : IApprenticeshipProviderRepository
    {
        private readonly ILog _applicationLogger;
        private readonly IConfigurationSettings _applicationSettings;
        private readonly IElasticsearchCustomClient _elasticsearchCustomClient;
        private readonly IProviderMapping _providerMapping;

        public ApprenticeshipProviderRepository(
            IElasticsearchCustomClient elasticsearchCustomClient,
            ILog applicationLogger,
            IConfigurationSettings applicationSettings,
            IProviderMapping providerMapping)
        {
            _elasticsearchCustomClient = elasticsearchCustomClient;
            _applicationLogger = applicationLogger;
            _applicationSettings = applicationSettings;
            _providerMapping = providerMapping;
        }

        public ApprenticeshipDetails GetCourseByStandardCode(int ukprn, int locationId, string standardCode)
        {
            try
            {
                var document =
                    GetProvider<StandardProviderSearchResultsItem>(
                        q =>
                        q.Term(t => t.Ukprn, ukprn)
                        && q.Term(t => t.StandardCode, standardCode)
                        && q.Nested(n => n
                            .Path(p => p.TrainingLocations)
                            .Query(nq => nq.Term(nt => nt.TrainingLocations.First().LocationId, locationId))));
                return _providerMapping.MapToProvider(document, locationId);
            }
            catch (Exception ex)
            {
                _applicationLogger.Error(
                    ex,
                    $"Trying to get standard with provider id {ukprn}, standard code {standardCode} and location id {locationId}");
                throw;
            }
        }

        public ApprenticeshipDetails GetCourseByFrameworkId(int ukprn, int locationId, string frameworkId)
        {
            try
            {
                var document =
                    GetProvider<FrameworkProviderSearchResultsItem>(
                        q =>
                        q.Term(t => t.Ukprn, ukprn)
                        && q.Term(t => t.FrameworkId, frameworkId)
                        && q.Nested(n => n
                            .Path(p => p.TrainingLocations)
                            .Query(nq => nq.Term(nt => nt.TrainingLocations.First().LocationId, locationId))));
                return _providerMapping.MapToProvider(document, locationId);
            }
            catch (Exception ex)
            {
                _applicationLogger.Error(
                    ex,
                    $"Trying to get standard with provider id {ukprn}, framework id {frameworkId} and location id {locationId}");
                throw;
            }
        }

        public int GetFrameworksAmountWithProviders()
        {
            try
            {
                var take = GetFrameworkProvidersTotalAmount();
                var document =
                    _elasticsearchCustomClient.Search<FrameworkProviderSearchResultsItem>(s => s
                        .Index(_applicationSettings.ProviderIndexAlias)
                        .Type("frameworkprovider")
                        .From(0)
                        .Take(take)
                        .MatchAll());
                var response = document.Documents.GroupBy(x => x.FrameworkId).Count();
                return response;
            }
            catch (Exception ex)
            {
                _applicationLogger.Error(
                    ex,
                    $"Error retrieving amount of frameworks with provider");
                throw;
            }
        }

        public int GetStandardsAmountWithProviders()
        {
            try
            {
                var take = GetStandardProvidersTotalAmount();
                var document =
                    _elasticsearchCustomClient.Search<StandardProviderSearchResultsItem>(s => s
                        .Index(_applicationSettings.ProviderIndexAlias)
                        .Type("standardprovider")
                        .From(0)
                        .Take(take)
                        .MatchAll());
                var response = document.Documents.GroupBy(x => x.StandardCode).Count();
                return response;
            }
            catch (Exception ex)
            {
                _applicationLogger.Error(
                    ex,
                    $"Error retrieving amount of standards with provider");
                throw;
            }
        }

        private int GetStandardProvidersTotalAmount()
        {
            var document =
                    _elasticsearchCustomClient.Search<StandardProviderSearchResultsItem>(s => s
                        .Index(_applicationSettings.ProviderIndexAlias)
                        .Type("standardprovider")
                        .MatchAll());
            return (int)document.HitsMetaData.Total;
        }

        private int GetFrameworkProvidersTotalAmount()
        {
            var document =
                    _elasticsearchCustomClient.Search<FrameworkProviderSearchResultsItem>(s => s
                        .Index(_applicationSettings.ProviderIndexAlias)
                        .Type("frameworkprovider")
                        .MatchAll());
            return (int)document.HitsMetaData.Total;
        }

        private T GetProvider<T>(Func<QueryContainerDescriptor<T>, QueryContainer> query)
            where T : class
        {
            var results = _elasticsearchCustomClient.Search<T>(s => s.Index(_applicationSettings.ProviderIndexAlias).From(0).Size(1).Query(query));

            if (results.ApiCall.HttpStatusCode != 200)
            {
                throw new ApplicationException($"Failed query standard with provider");
            }

            var document = results.Documents.Any() ? results.Documents.First() : null;

            return document;
        }
    }
}