﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sfa.Das.Sas.Web.Views.Apprenticeship
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Sfa.Das.Sas.Web;
    
    #line 2 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/SearchResults.cshtml")]
    public partial class SearchResults : System.Web.Mvc.WebViewPage<ApprenticeshipSearchResultViewModel>
    {

#line 91 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationBackLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 92 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (Model.ActualPage <= 1)
    {
        return;
    }

    var previousPage = @Model.ActualPage - 1;
    var url = @Url.Action("SearchResults", "Apprenticeship", GetNavigationRouteValues(previousPage, Model.AggregationLevel, Model.SortOrder), null);
    

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4184), Tuple.Create("\"", 4195)

#line 100 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4191), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 4191), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn prev\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-left\"");

WriteLiteralTo(__razor_helper_writer, "></i>\r\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Previous <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\r\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 103 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, previousPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 103 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                 WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n    </a>\r\n");


#line 105 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 105 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 108 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationNextLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 109 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (Model.ActualPage >= Model.LastPage || Model.ActualPage < 0)
    {
        return;
    }

    var nextPage = @Model.ActualPage + 1;

    var url = @Url.Action("SearchResults", "Apprenticeship", GetNavigationRouteValues(nextPage, Model.AggregationLevel, Model.SortOrder), null);
    

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4825), Tuple.Create("\"", 4836)

#line 118 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4832), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 4832), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn next\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-right\"");

WriteLiteralTo(__razor_helper_writer, "></i>\r\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Next <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\r\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 121 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, nextPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 121 "..\..\Views\Apprenticeship\SearchResults.cshtml"
             WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n    </a>\r\n");


#line 123 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 123 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

        #line 127 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    RouteValueDictionary GetNavigationRouteValues(int page, IEnumerable<LevelAggregationViewModel> selectedLevels, string order)
    {

        var rv = new RouteValueDictionary { { "keywords", Model.SearchTerm }, { "page", page }, { "order", order }, { "take", Model.ResultsToTake } };
        var i = 0;
        foreach (var level in selectedLevels.Where(m => m.Checked))
        {
            rv.Add("SelectedLevels[" + i + "]", level.Value);
            i++;
        }
        return rv;
    }

        #line default
        #line hidden

#line 143 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetStandardTitle(ApprenticeshipSearchResultItemViewModel item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 144 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"result-title\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 146 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink(item.Title, "Standard", "Apprenticeship", new { @id = item.StandardId, @keywords = Model.SearchTerm }, null));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"tag tag-new\"");

WriteLiteralTo(__razor_helper_writer, ">New</span>\r\n    </h2>\r\n");


#line 149 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 149 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 151 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetFrameworkTitle(ApprenticeshipSearchResultItemViewModel item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 152 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"result-title\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 154 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink(item.Title, "Framework", "Apprenticeship", new { @id = item.FrameworkId, @keywords = Model.SearchTerm }, null));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n    </h2>\r\n");


#line 156 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 156 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 158 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetApprenticeshipDetailItem(string title, string id, string item, string unit = "")
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 159 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (string.IsNullOrEmpty(item))
    {
        return;
    }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt><b>");


#line 164 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b></dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 6418), Tuple.Create("\"", 6429)

#line 165 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6426), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 6426), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 165 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, item);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 165 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, unit);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 166 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 166 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 168 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult FilterForm(string className)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 169 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (Model.TotalResults <= 0)
    {
        return;
    }



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 6570), Tuple.Create("\"", 6602)
, Tuple.Create(Tuple.Create("", 6578), Tuple.Create("filters-block", 6578), true)

#line 175 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 6591), Tuple.Create<System.Object, System.Int32>(className

#line default
#line hidden
, 6592), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n        <form");

WriteLiteralTo(__razor_helper_writer, " method=\"get\"");

WriteLiteralTo(__razor_helper_writer, " autocomplete=\"off\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"Keywords\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 6702), Tuple.Create("\"", 6727)

#line 177 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6710), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm

#line default
#line hidden
, 6710), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n            <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"order\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 6778), Tuple.Create("\"", 6802)

#line 178 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6786), Tuple.Create<System.Object, System.Int32>(Model.SortOrder

#line default
#line hidden
, 6786), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n\r\n            <fieldset");

WriteLiteralTo(__razor_helper_writer, " class=\"filters filters-accordion\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"toggler heading-small\"");

WriteLiteralTo(__razor_helper_writer, ">Apprenticeship level</h2>\r\n                <div");

WriteLiteralTo(__razor_helper_writer, " class=\"toggled-content\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <ul");

WriteLiteralTo(__razor_helper_writer, " name=\"alist22\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 184 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                        

#line default
#line hidden

#line 184 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                         foreach (var item in Model.AggregationLevel.OrderBy(m => m.Value))
                        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                            <li>\r\n                                <input");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 7225), Tuple.Create("\"", 7244)

#line 187 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7233), Tuple.Create<System.Object, System.Int32>(item.Value

#line default
#line hidden
, 7233), false)
);

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 7245), Tuple.Create("\"", 7278)
, Tuple.Create(Tuple.Create("", 7250), Tuple.Create("SelectedLevels_", 7250), true)

#line 187 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7265), Tuple.Create<System.Object, System.Int32>(item.Value

#line default
#line hidden
, 7265), false)
);

WriteLiteralTo(__razor_helper_writer, " name=\"SelectedLevels\"");

WriteLiteralTo(__razor_helper_writer, " type=\"checkbox\"");

WriteLiteralTo(__razor_helper_writer, " ");


#line 187 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                     WriteTo(__razor_helper_writer, Html.Raw(item.Checked ? "checked" : ""));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 187 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                                                              WriteTo(__razor_helper_writer, Html.Raw(item.Count == 0 ? "disabled" : ""));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " />\r\n                                <label");

WriteAttributeTo(__razor_helper_writer, "for", Tuple.Create(" for=\"", 7446), Tuple.Create("\"", 7480)
, Tuple.Create(Tuple.Create("", 7452), Tuple.Create("SelectedLevels_", 7452), true)

#line 188 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7467), Tuple.Create<System.Object, System.Int32>(item.Value

#line default
#line hidden
, 7467), false)
);

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 7481), Tuple.Create("\"", 7533)

#line 188 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 , Tuple.Create(Tuple.Create("", 7489), Tuple.Create<System.Object, System.Int32>(Html.Raw(item.Count == 0 ? "disabled" : "")

#line default
#line hidden
, 7489), false)
);

WriteLiteralTo(__razor_helper_writer, ">level ");


#line 188 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                       WriteTo(__razor_helper_writer, item.Value);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " (");


#line 188 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                                    WriteTo(__razor_helper_writer, item.Count);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ")</label>\r\n                            </li>\r\n");


#line 190 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                    </ul>\r\n\r\n                    <details>\r\n                     " +
"   <summary>Explain levels</summary>\r\n                        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"panel panel-border-narrow\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                            <p>Apprenticeships are set at different levels of " +
"difficulty from the equivalent of GCSE (level 2) up to postgraduate (level 7)</p" +
">\r\n                            <p><a");

WriteLiteralTo(__razor_helper_writer, " href=\"https://www.gov.uk/what-different-qualification-levels-mean/overview\"");

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, " rel=\"external\"");

WriteLiteralTo(__razor_helper_writer, ">More about levels</a></p>\r\n                        </div>\r\n                    <" +
"/details>\r\n                    \r\n\r\n                </div>\r\n            </fieldse" +
"t>\r\n            <input");

WriteLiteralTo(__razor_helper_writer, " type=\"submit\"");

WriteLiteralTo(__razor_helper_writer, " class=\"button\"");

WriteLiteralTo(__razor_helper_writer, " value=\"Update results\"");

WriteLiteralTo(__razor_helper_writer, " />\r\n        </form>\r\n    </div>\r\n");


#line 207 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 207 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

        public SearchResults()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Apprenticeship\SearchResults.cshtml"
  
    ViewBag.Title = "Search Results";

            
            #line default
            #line hidden
WriteLiteral("\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 219), Tuple.Create("\"", 244)
            
            #line 9 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 227), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm
            
            #line default
            #line hidden
, 227), false)
);

WriteLiteral(" id=\"ga-search-term\"");

WriteLiteral("/>\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 293), Tuple.Create("\"", 342)
            
            #line 10 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 301), Tuple.Create<System.Object, System.Int32>(Model.Results.IsNullOrEmpty().ToString()
            
            #line default
            #line hidden
, 301), false)
);

WriteLiteral(" id=\"ga-no-result\"");

WriteLiteral(" />\r\n\r\n    <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 13 "..\..\Views\Apprenticeship\SearchResults.cshtml"
   Write(Html.ActionLink("Start a new search", "Search", "Apprenticeship", new { }, new { @class = "link-back new-apprenticeship-search" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n    <hgroup");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n        <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n            Search results\r\n        </h1>\r\n");

            
            #line 19 "..\..\Views\Apprenticeship\SearchResults.cshtml"
        
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Apprenticeship\SearchResults.cshtml"
          
            Html.RenderPartial("_SearchResultMessage");
        
            
            #line default
            #line hidden
WriteLiteral("\r\n    </hgroup>\r\n\r\n");

            
            #line 24 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Apprenticeship\SearchResults.cshtml"
     if (Model.TotalResults == 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p>You can:</p>\r\n");

WriteLiteral("        <ul");

WriteLiteral(" class=\"list-bullet\"");

WriteLiteral(">\r\n            <li>");

            
            #line 28 "..\..\Views\Apprenticeship\SearchResults.cshtml"
           Write(Html.ActionLink("start your job role or keyword search again", "Search", "Apprenticeship", new { }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        </ul>\r\n");

            
            #line 30 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n\r\n");

            
            #line 34 "..\..\Views\Apprenticeship\SearchResults.cshtml"
        
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\Apprenticeship\SearchResults.cshtml"
         if (!Model.HasError && Model.TotalResults > 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"column-one-third\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"editSearch\"");

WriteLiteral(">\r\n                    <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"#EditSearch\"");

WriteLiteral(">Filter results</a>\r\n                    </h2>\r\n                    <div");

WriteLiteral(" id=\"EditSearch\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 42 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                   Write(FilterForm("filter-box"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");

            
            #line 46 "..\..\Views\Apprenticeship\SearchResults.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"apprenticeship-results\"");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n                <form");

WriteLiteral(" method=\"GET\"");

WriteLiteral(" id=\"search-results-order\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"Keywords\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1693), Tuple.Create("\"", 1718)
            
            #line 49 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1701), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm
            
            #line default
            #line hidden
, 1701), false)
);

WriteLiteral("/>\r\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"page\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1775), Tuple.Create("\"", 1800)
            
            #line 50 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1783), Tuple.Create<System.Object, System.Int32>(Model.ActualPage
            
            #line default
            #line hidden
, 1783), false)
);

WriteLiteral("/>\r\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"take\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1857), Tuple.Create("\"", 1885)
            
            #line 51 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1865), Tuple.Create<System.Object, System.Int32>(Model.ResultsToTake
            
            #line default
            #line hidden
, 1865), false)
);

WriteLiteral("/>\r\n");

            
            #line 52 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                     foreach (var level in Model.AggregationLevel.Where(level => level.Checked))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"SelectedLevels\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2077), Tuple.Create("\"", 2097)
            
            #line 54 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2085), Tuple.Create<System.Object, System.Int32>(level.Value
            
            #line default
            #line hidden
, 2085), false)
);

WriteLiteral("/>\r\n");

            
            #line 55 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-block\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"select-order\"");

WriteLiteral(" class=\"form-label-bold\"");

WriteLiteral(">Sort by</label>\r\n                        <select");

WriteLiteral(" name=\"order\"");

WriteLiteral(" id=\"select-order\"");

WriteLiteral(" class=\"form-control form-control-1-3\"");

WriteLiteral(">\r\n                            <option");

WriteAttribute("selected", Tuple.Create(" selected=\"", 2400), Tuple.Create("\"", 2436)
            
            #line 59 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2411), Tuple.Create<System.Object, System.Int32>(Model.SortOrder == "1"
            
            #line default
            #line hidden
, 2411), false)
);

WriteLiteral(" value=\"1\"");

WriteLiteral(">Best match</option>\r\n                            <option");

WriteAttribute("selected", Tuple.Create(" selected=\"", 2504), Tuple.Create("\"", 2540)
            
            #line 60 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2515), Tuple.Create<System.Object, System.Int32>(Model.SortOrder == "2"
            
            #line default
            #line hidden
, 2515), false)
);

WriteLiteral(" value=\"2\"");

WriteLiteral(">Level (high to low)</option>\r\n                            <option");

WriteAttribute("selected", Tuple.Create(" selected=\"", 2617), Tuple.Create("\"", 2653)
            
            #line 61 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2628), Tuple.Create<System.Object, System.Int32>(Model.SortOrder == "3"
            
            #line default
            #line hidden
, 2628), false)
);

WriteLiteral(" value=\"3\"");

WriteLiteral(">Level (low to high)</option>\r\n                        </select>\r\n               " +
"         <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Sort\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Sort</button>\r\n                    </div>\r\n                </form>\r\n\r\n\r\n");

            
            #line 68 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 68 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                 foreach (var item in Model.Results)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <article");

WriteAttribute("class", Tuple.Create(" class=\"", 2977), Tuple.Create("\"", 3025)
, Tuple.Create(Tuple.Create("", 2985), Tuple.Create("result", 2985), true)
            
            #line 70 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 2991), Tuple.Create<System.Object, System.Int32>(item.ApprenticeshipType
            
            #line default
            #line hidden
, 2992), false)
, Tuple.Create(Tuple.Create("", 3018), Tuple.Create("-result", 3018), true)
);

WriteAttribute("id", Tuple.Create(" id=\"", 3026), Tuple.Create("\"", 3130)
            
            #line 70 "..\..\Views\Apprenticeship\SearchResults.cshtml"
   , Tuple.Create(Tuple.Create("", 3031), Tuple.Create<System.Object, System.Int32>(item.ApprenticeshipType
            
            #line default
            #line hidden
, 3031), false)
, Tuple.Create(Tuple.Create("", 3057), Tuple.Create("-", 3057), true)
            
            #line 70 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                              , Tuple.Create(Tuple.Create("", 3058), Tuple.Create<System.Object, System.Int32>(!item.StandardId.IsNullOrEmpty() ? item.StandardId : item.FrameworkId
            
            #line default
            #line hidden
, 3058), false)
);

WriteLiteral(">\r\n                        <header>\r\n");

WriteLiteral("                            ");

            
            #line 72 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                        Write(!item.StandardId.IsNullOrEmpty() ? GetStandardTitle(item) : GetFrameworkTitle(item));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </header>\r\n                        <dl");

WriteLiteral(" class=\"result-data-list\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 75 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                       Write(GetApprenticeshipDetailItem("Level:", "level", item.Level));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 76 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                       Write(GetApprenticeshipDetailItem("Typical length:", "length", item.TypicalLengthMessage));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </dl>\r\n                    </article>\r\n");

            
            #line 79 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"page-navigation\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 82 "..\..\Views\Apprenticeship\SearchResults.cshtml"
               Write(GetPaginationBackLink());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 83 "..\..\Views\Apprenticeship\SearchResults.cshtml"
               Write(GetPaginationNextLink());

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

            
            #line 86 "..\..\Views\Apprenticeship\SearchResults.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</main>\r\n\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
