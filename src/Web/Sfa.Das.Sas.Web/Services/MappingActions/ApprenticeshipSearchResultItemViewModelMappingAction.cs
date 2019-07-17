﻿using AutoMapper;
using Sfa.Das.Sas.ApplicationServices.Models;
using Sfa.Das.Sas.Web.Services.MappingActions.Helpers;
using Sfa.Das.Sas.Web.ViewModels;

namespace Sfa.Das.Sas.Web.Services.MappingActions
{
    using Sfa.Das.Sas.Web.Extensions;

    using Resources = Resources.EquivalenceLevels;

    internal class ApprenticeshipSearchResultItemViewModelMappingAction :
        IMappingAction<ApprenticeshipSearchResultsItem, ApprenticeshipSearchResultItemViewModel>
    {
        public void Process(ApprenticeshipSearchResultsItem source, ApprenticeshipSearchResultItemViewModel destination)
        {
            destination.Level = GetLevelText(source.Level);
            switch (source.ApprenticeshipType)
            {
                case ApprenticeshipType.Framework:
                    destination.ApprenticeshipType = Models.ApprenticeshipType.Framework;
                    break;
                case ApprenticeshipType.Standard:
                    destination.ApprenticeshipType = Models.ApprenticeshipType.Standard;
                    break;
            }
            
            destination.Title = ApprenticeshipMappingHelper.FrameworkTitle(source.Title);
        }

        private static string GetLevelText(int item)
        {
            string equivalence;

            switch (item)
            {
                case 1:
                    equivalence = Resources.FirstLevel;
                    break;
                case 2:
                    equivalence = Resources.SecondLevel;
                    break;
                case 3:
                    equivalence = Resources.ThirdLevel;
                    break;
                case 4:
                    equivalence = Resources.FourthLevel;
                    break;
                case 5:
                    equivalence = Resources.FifthLevel;
                    break;
                case 6:
                    equivalence = Resources.SixthLevel;
                    break;
                case 7:
                    equivalence = Resources.SeventhLevel;
                    break;
                case 8:
                    equivalence = Resources.EighthLevel;
                    break;
                default:
                    equivalence = string.Empty;
                    break;
            }

            return !string.IsNullOrEmpty(equivalence) ? $"{item} (equivalent to {equivalence})" : string.Empty;
        }
    }
}