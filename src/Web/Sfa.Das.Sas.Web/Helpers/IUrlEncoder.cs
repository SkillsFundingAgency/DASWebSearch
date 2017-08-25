﻿using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Sfa.Das.Sas.Web.Helpers
{
    public interface IUrlEncoder
    {
        string EncodeTextForUri(string providerNameToProcess);
    }

    public class UrlEncoder : IUrlEncoder
    {
        public string EncodeTextForUri(string providerNameToProcess)
        {
            var lowerCaseAndApostrophesAndHyphensRemoved = Regex.Replace(providerNameToProcess.ToLower(),"['-]", string.Empty);
            var removePeriods = lowerCaseAndApostrophesAndHyphensRemoved.Replace(".", string.Empty);
            var ampersandAndPlusReplaced = Regex.Replace(removePeriods, "[&+]", "and");
            var splitBySpacesAndOtherChars = Regex.Split(ampersandAndPlusReplaced, @"[\s(),]+");
            var rebuildExcludingNoContent = string.Join(
                "-",
                splitBySpacesAndOtherChars.Except(new List<string> {string.Empty})
            );

         return Regex.Escape(rebuildExcludingNoContent);
     }
    }
}