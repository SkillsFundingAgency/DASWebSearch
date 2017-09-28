﻿using System.Collections.Generic;
using System.Threading.Tasks;
using SFA.DAS.Apprenticeships.Api.Types.AssessmentOrgs;
using SFA.DAS.AssessmentOrgs.Api.Client;

namespace Sfa.Das.Sas.Infrastructure.Repositories
{
    public sealed class AssessmentOrganisationApiRepository : IAssessmentOrgsApiClient
    {
        private readonly IAssessmentOrgsApiClient _apiClient;

        public AssessmentOrganisationApiRepository(IAssessmentOrgsApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public void Dispose()
        {
            _apiClient.Dispose();
        }

        public Organisation Get(string organisationId)
        {
            return _apiClient.Get(organisationId);
        }

        public async Task<Organisation> GetAsync(string organisationId)
        {
            return await _apiClient.GetAsync(organisationId);
        }

        public IEnumerable<Organisation> ByStandard(int standardId)
        {
            return _apiClient.ByStandard(standardId);
        }

        public async Task<IEnumerable<Organisation>> ByStandardAsync(int standardId)
        {
            return await _apiClient.ByStandardAsync(standardId);
        }

        public IEnumerable<Organisation> ByStandard(string standardId)
        {
            return _apiClient.ByStandard(standardId);
        }

        public async Task<IEnumerable<Organisation>> ByStandardAsync(string standardId)
        {
            return await _apiClient.ByStandardAsync(standardId);
        }

        public IEnumerable<OrganisationSummary> FindAll()
        {
            return _apiClient.FindAll();
        }

        public async Task<IEnumerable<OrganisationSummary>> FindAllAsync()
        {
            return await _apiClient.FindAllAsync();
        }

        public bool Exists(string organisationId)
        {
            return _apiClient.Exists(organisationId);
        }

        public async Task<bool> ExistsAsync(string organisationId)
        {
            return await _apiClient.ExistsAsync(organisationId);
        }
    }
}
