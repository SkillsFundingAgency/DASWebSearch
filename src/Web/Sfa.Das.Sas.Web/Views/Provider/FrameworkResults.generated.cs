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

namespace Sfa.Das.Sas.Web.Views.Provider
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
    
    #line 1 "..\..\Views\Provider\FrameworkResults.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Provider\FrameworkResults.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/FrameworkResults.cshtml")]
    public partial class FrameworkResults : System.Web.Mvc.WebViewPage<ProviderFrameworkSearchResultViewModel>
    {

#line 92 "..\..\Views\Provider\FrameworkResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationBackLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 93 "..\..\Views\Provider\FrameworkResults.cshtml"
 
if (Model.ActualPage > 1)
{
    var previousPage = @Model.ActualPage - 1;
    var url = @Url.Action("FrameworkResults", "Provider", GetNavigationRouteValues(previousPage, Model.DeliveryModes), null);

        

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4155), Tuple.Create("\"", 4166)

#line 99 "..\..\Views\Provider\FrameworkResults.cshtml"
, Tuple.Create(Tuple.Create("", 4162), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 4162), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn prev\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-left\"");

WriteLiteralTo(__razor_helper_writer, "></i>\r\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Previous <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\r\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 102 "..\..\Views\Provider\FrameworkResults.cshtml"
    WriteTo(__razor_helper_writer, previousPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 102 "..\..\Views\Provider\FrameworkResults.cshtml"
                     WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n        </a>\r\n");


#line 104 "..\..\Views\Provider\FrameworkResults.cshtml"
}


#line default
#line hidden
});

#line 105 "..\..\Views\Provider\FrameworkResults.cshtml"
}
#line default
#line hidden

#line 108 "..\..\Views\Provider\FrameworkResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationNextLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 109 "..\..\Views\Provider\FrameworkResults.cshtml"
 
if (Model.ActualPage < Model.LastPage)
{
    var nextPage = @Model.ActualPage + 1;

    var url = @Url.Action("FrameworkResults", "Provider", GetNavigationRouteValues(nextPage, Model.DeliveryModes), null);

        

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4739), Tuple.Create("\"", 4750)

#line 116 "..\..\Views\Provider\FrameworkResults.cshtml"
, Tuple.Create(Tuple.Create("", 4746), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 4746), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn next\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-right\"");

WriteLiteralTo(__razor_helper_writer, "></i>\r\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Next <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\r\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 119 "..\..\Views\Provider\FrameworkResults.cshtml"
    WriteTo(__razor_helper_writer, nextPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 119 "..\..\Views\Provider\FrameworkResults.cshtml"
                 WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n        </a>\r\n");


#line 121 "..\..\Views\Provider\FrameworkResults.cshtml"
}


#line default
#line hidden
});

#line 122 "..\..\Views\Provider\FrameworkResults.cshtml"
}
#line default
#line hidden

#line 124 "..\..\Views\Provider\FrameworkResults.cshtml"
public System.Web.WebPages.HelperResult FilterForm(string cssClass)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 125 "..\..\Views\Provider\FrameworkResults.cshtml"
 
if (!Model.DeliveryModes.IsNullOrEmpty())
{
    var hideMenu = true;
    foreach (var deliveryMode in Model.DeliveryModes.Where(deliveryMode => deliveryMode.Count != 0))
    {
        hideMenu = false;
    }

    if (@Model.TotalResults != 0 || !hideMenu)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"editSearch\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"heading-medium\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <a");

WriteLiteralTo(__razor_helper_writer, " href=\"#EditSearch\"");

WriteLiteralTo(__razor_helper_writer, ">Filter results</a>\r\n                </h2>\r\n                <div");

WriteLiteralTo(__razor_helper_writer, " id=\"EditSearch\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <div");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 5598), Tuple.Create("\"", 5629)
, Tuple.Create(Tuple.Create("", 5606), Tuple.Create("filters-block", 5606), true)

#line 141 "..\..\Views\Provider\FrameworkResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 5619), Tuple.Create<System.Object, System.Int32>(cssClass

#line default
#line hidden
, 5620), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n                        <form");

WriteLiteralTo(__razor_helper_writer, " method=\"get\"");

WriteLiteralTo(__razor_helper_writer, " autocomplete=\"off\"");

WriteAttributeTo(__razor_helper_writer, "action", Tuple.Create(" action=\"", 5694), Tuple.Create("\"", 5722)

#line 142 "..\..\Views\Provider\FrameworkResults.cshtml"
, Tuple.Create(Tuple.Create("", 5703), Tuple.Create<System.Object, System.Int32>(Model.AbsolutePath

#line default
#line hidden
, 5703), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n                            <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"PostCode\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 5790), Tuple.Create("\"", 5813)

#line 143 "..\..\Views\Provider\FrameworkResults.cshtml"
, Tuple.Create(Tuple.Create("", 5798), Tuple.Create<System.Object, System.Int32>(Model.PostCode

#line default
#line hidden
, 5798), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n                            <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"apprenticeshipid\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 5891), Tuple.Create("\"", 5917)

#line 144 "..\..\Views\Provider\FrameworkResults.cshtml"
, Tuple.Create(Tuple.Create("", 5899), Tuple.Create<System.Object, System.Int32>(Model.FrameworkId

#line default
#line hidden
, 5899), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n                            <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"ShowAll\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 5986), Tuple.Create("\"", 6019)

#line 145 "..\..\Views\Provider\FrameworkResults.cshtml"
, Tuple.Create(Tuple.Create("", 5994), Tuple.Create<System.Object, System.Int32>(Model.ShowAll.ToString()

#line default
#line hidden
, 5994), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n                            <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"keywords\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 6089), Tuple.Create("\"", 6115)

#line 146 "..\..\Views\Provider\FrameworkResults.cshtml"
, Tuple.Create(Tuple.Create("", 6097), Tuple.Create<System.Object, System.Int32>(Model.SearchTerms

#line default
#line hidden
, 6097), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n");


#line 147 "..\..\Views\Provider\FrameworkResults.cshtml"
                            

#line default
#line hidden

#line 147 "..\..\Views\Provider\FrameworkResults.cshtml"
                              
                                Html.RenderPartial("_FilterProviders", Model.DeliveryModes);
                            

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 150 "..\..\Views\Provider\FrameworkResults.cshtml"
                            

#line default
#line hidden

#line 150 "..\..\Views\Provider\FrameworkResults.cshtml"
                              
                                Html.RenderPartial("_FilterNationalProviders", Model.NationalProviders);
                            

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                            <input");

WriteLiteralTo(__razor_helper_writer, " type=\"submit\"");

WriteLiteralTo(__razor_helper_writer, " value=\"Update results\"");

WriteLiteralTo(__razor_helper_writer, " class=\"button margin-top-x2 postcode-search-button\"");

WriteLiteralTo(__razor_helper_writer, " />\r\n                        </form>\r\n                    </div>\r\n               " +
" </div>\r\n            </div>\r\n");


#line 158 "..\..\Views\Provider\FrameworkResults.cshtml"
                                    }
                                }


#line default
#line hidden
});

#line 160 "..\..\Views\Provider\FrameworkResults.cshtml"
}
#line default
#line hidden

        #line 163 "..\..\Views\Provider\FrameworkResults.cshtml"
 
    RouteValueDictionary GetNavigationRouteValues(int page, IEnumerable<DeliveryModeViewModel> deliveryModes)
    {

        var rv = new RouteValueDictionary { { "apprenticeshipid", Model.FrameworkId }, { "postcode", Model.PostCode }, { "page", page }, { "showall", Model.ShowAll } };
        int i = 0;
        foreach (var deliveryMode in deliveryModes.Where(m => m.Checked))
        {
            rv.Add("DeliveryModes[" + i + "]", deliveryMode.Value);
            i++;
        }
        return rv;
    }

        #line default
        #line hidden
        
        public FrameworkResults()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Provider\FrameworkResults.cshtml"
  
    ViewBag.Title = "Provider Search Results";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\Provider\FrameworkResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Provider\FrameworkResults.cshtml"
     if (Model.Hits.Count() != 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 13 "..\..\Views\Provider\FrameworkResults.cshtml"
       Write(Html.ActionLink("Find providers for a different postcode", "SearchForFrameworkProviders", "Apprenticeship", new { @frameworkId = Model.FrameworkId, @keywords = Model.SearchTerms }, new { @class = "link-back new-postcode-search" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </p>\r\n");

            
            #line 15 "..\..\Views\Provider\FrameworkResults.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div>\r\n        <div>\r\n            <hgroup");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n                    Search results\r\n                </h1>\r\n\r\n");

            
            #line 23 "..\..\Views\Provider\FrameworkResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Provider\FrameworkResults.cshtml"
                  
                    Html.RenderPartial("_FrameworkSearchResultMessage");
                
            
            #line default
            #line hidden
WriteLiteral("\r\n            </hgroup>\r\n\r\n            <div");

WriteLiteral(" class=\"result-message\"");

WriteLiteral(">\r\n");

            
            #line 29 "..\..\Views\Provider\FrameworkResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\Provider\FrameworkResults.cshtml"
                 if (Model.ShowNationalProviders && Model.TotalResults == 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <p");

WriteLiteral(" id=\"framework-provider-search-message\"");

WriteLiteral(">\r\n                        Sorry, there are currently no results for the filters " +
"you applied\'.\r\n                    </p>\r\n");

WriteLiteral("                    <div>\r\n                        <p>You can:</p>\r\n             " +
"           <ul");

WriteLiteral(" class=\"list list-bullet\"");

WriteLiteral(">\r\n                            <li");

WriteLiteral(" class=\"return-search-results\"");

WriteLiteral(">");

            
            #line 37 "..\..\Views\Provider\FrameworkResults.cshtml"
                                                         Write(Html.ActionLink("return to your apprenticeship training search results", "FrameworkResults", "Provider", new { @apprenticeshipid = @Model.FrameworkId, @postcode = @Model.PostCode, @keywords = @Model.SearchTerms }, new { }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                            <li");

WriteLiteral(" class=\"start-again\"");

WriteLiteral(">");

            
            #line 38 "..\..\Views\Provider\FrameworkResults.cshtml"
                                               Write(Html.ActionLink("start your job role or keyword search again", "Search", "Apprenticeship"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                        </ul>\r\n                    </div>\r\n");

            
            #line 41 "..\..\Views\Provider\FrameworkResults.cshtml"
                }
                else if (Model.TotalResults == 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <p>\r\n                        Sorry, there are currently no tr" +
"aining providers for <b>");

            
            #line 45 "..\..\Views\Provider\FrameworkResults.cshtml"
                                                                           Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral(", level ");

            
            #line 45 "..\..\Views\Provider\FrameworkResults.cshtml"
                                                                                               Write(Model.FrameworkLevel);

            
            #line default
            #line hidden
WriteLiteral("</b> for \'<b");

WriteLiteral(" id=\"postalcode\"");

WriteLiteral(">");

            
            #line 45 "..\..\Views\Provider\FrameworkResults.cshtml"
                                                                                                                                                 Write(Model.PostCode);

            
            #line default
            #line hidden
WriteLiteral("</b>\'.\r\n                    </p>\r\n");

WriteLiteral("                    <div>\r\n                        You can:\r\n                    " +
"    <ul");

WriteLiteral(" class=\"list list-bullet\"");

WriteLiteral(">\r\n");

            
            #line 50 "..\..\Views\Provider\FrameworkResults.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Provider\FrameworkResults.cshtml"
                             if (Model.TotalProvidersCountry > 0)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li");

WriteLiteral(" class=\"total-providers-country\"");

WriteLiteral(">");

            
            #line 52 "..\..\Views\Provider\FrameworkResults.cshtml"
                                                               Write(Html.ActionLink($"view all ({@Model.TotalProvidersCountry}) training providers", "FrameworkResults", "Provider", new { @apprenticeshipId = @Model.FrameworkId, @postcode = Model.PostCode, @showAll = true }, new { @class = "" }));

            
            #line default
            #line hidden
WriteLiteral(" for <b>");

            
            #line 52 "..\..\Views\Provider\FrameworkResults.cshtml"
                                                                                                                                                                                                                                                                                                          Write(Model.FrameworkName);

            
            #line default
            #line hidden
WriteLiteral(", level ");

            
            #line 52 "..\..\Views\Provider\FrameworkResults.cshtml"
                                                                                                                                                                                                                                                                                                                                      Write(Model.FrameworkLevel);

            
            #line default
            #line hidden
WriteLiteral("</b> in England</li>\r\n");

            
            #line 53 "..\..\Views\Provider\FrameworkResults.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            <li");

WriteLiteral(" class=\"return-search-results\"");

WriteLiteral(">");

            
            #line 54 "..\..\Views\Provider\FrameworkResults.cshtml"
                                                         Write(Html.ActionLink("return to your apprenticeship training search results", "SearchResults", "Apprenticeship", new { @keywords = @Model.SearchTerms }, new { }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                            <li");

WriteLiteral(" class=\"start-again\"");

WriteLiteral(">");

            
            #line 55 "..\..\Views\Provider\FrameworkResults.cshtml"
                                               Write(Html.ActionLink("start your job role or keyword search again", "Search", "Apprenticeship"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                        </ul>\r\n                    </div>\r\n");

            
            #line 58 "..\..\Views\Provider\FrameworkResults.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("            ");

            
            #line 66 "..\..\Views\Provider\FrameworkResults.cshtml"
       Write(FilterForm("filter-box"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" id=\"provider-results\"");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n");

            
            #line 69 "..\..\Views\Provider\FrameworkResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 69 "..\..\Views\Provider\FrameworkResults.cshtml"
              
                Html.RenderPartial("_FrameworkProviderInformation");
            
            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div");

WriteLiteral(" class=\"page-navigation\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 77 "..\..\Views\Provider\FrameworkResults.cshtml"
   Write(GetPaginationBackLink());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 78 "..\..\Views\Provider\FrameworkResults.cshtml"
   Write(GetPaginationNextLink());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n</main>\r\n\r\n");

            
            #line 83 "..\..\Views\Provider\FrameworkResults.cshtml"
 if (Model.TotalResults == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <script>\r\n        window.onload = function () {\r\n            SearchAndShortli" +
"st.analytics.pushEvent(\"Provider Search\", \"No results\", \"Search\");\r\n        }\r\n " +
"   </script>\r\n");

            
            #line 90 "..\..\Views\Provider\FrameworkResults.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
