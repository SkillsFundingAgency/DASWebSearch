﻿using System;
using System.Collections.Generic;

namespace SFA.DAS.Apprenticeships.Api.Client
{
    using Sfa.Das.ApprenticeshipInfoService.Core.Models;

    public interface IStandardApiClient : IDisposable
    {
        /// <summary>
        /// Get a single standard details
        /// GET /standards/{standard-code}
        /// </summary>
        /// <param name="standardCode">An integer for the standard id (LARS code) ie: 12</param>
        /// <returns>a standard</returns>
        Standard Get(int standardCode);

        /// <summary>
        /// Check if a standard exists
        /// HEAD /standards/{standard-code}
        /// </summary>
        /// <param name="standardCode">An integer for the standard id (LARS code) ie: 12</param>
        /// <returns>bool</returns>
        IEnumerable<StandardSummary> FindAll();

        /// <summary>
        /// Check if a standard exists
        /// HEAD /standards/{standard-code}
        /// </summary>
        /// <param name="standardCode">An integer for the standard id (LARS code) ie: 12</param>
        /// <returns>bool</returns>
        bool Exists(int standardCode);
    }
}