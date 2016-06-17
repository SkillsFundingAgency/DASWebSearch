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

namespace Sfa.Das.Sas.Web.Views.Dashboard
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
    
    #line 1 "..\..\Views\Dashboard\Overview.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Dashboard\Overview.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Dashboard/Overview.cshtml")]
    public partial class Overview : System.Web.Mvc.WebViewPage<DashboardViewModel>
    {

#line 23 "..\..\Views\Dashboard\Overview.cshtml"
public System.Web.WebPages.HelperResult DisplayEmptyShortlistMessage(DashboardViewModel viewModel)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 24 "..\..\Views\Dashboard\Overview.cshtml"
 
    var emptyMessageClasses = viewModel.Apprenticeships.IsNullOrEmpty() ? string.Empty : "hidden";



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <p");

WriteLiteralTo(__razor_helper_writer, " id=\"empty-shortlist-message\"");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 664), Tuple.Create("\"", 699)
, Tuple.Create(Tuple.Create("", 672), Tuple.Create("notice", 672), true)

#line 27 "..\..\Views\Dashboard\Overview.cshtml"
, Tuple.Create(Tuple.Create(" ", 678), Tuple.Create<System.Object, System.Int32>(emptyMessageClasses

#line default
#line hidden
, 679), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n        You have no apprenticeship training shortlisted.&nbsp;\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 29 "..\..\Views\Dashboard\Overview.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink("Search for apprenticeship training", "Search", "Apprenticeship"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n    </p>\r\n");


#line 31 "..\..\Views\Dashboard\Overview.cshtml"


#line default
#line hidden
});

#line 31 "..\..\Views\Dashboard\Overview.cshtml"
}
#line default
#line hidden

#line 33 "..\..\Views\Dashboard\Overview.cshtml"
public System.Web.WebPages.HelperResult GetLink(IShortlistApprenticeshipViewModel model)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 34 "..\..\Views\Dashboard\Overview.cshtml"
 
    var method = model is ShortlistStandardViewModel ? "Standard" : "Framework";
    var apprenticeshipName = $"{model.Title}, level {model.Level}";
    

#line default
#line hidden

#line 37 "..\..\Views\Dashboard\Overview.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink(apprenticeshipName, method, "Apprenticeship", new { id = model.Id }, null));


#line default
#line hidden

#line 37 "..\..\Views\Dashboard\Overview.cshtml"
                                                                                               


#line default
#line hidden
});

#line 38 "..\..\Views\Dashboard\Overview.cshtml"
}
#line default
#line hidden

#line 40 "..\..\Views\Dashboard\Overview.cshtml"
public System.Web.WebPages.HelperResult GetDeleteLink(IShortlistApprenticeshipViewModel model)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 41 "..\..\Views\Dashboard\Overview.cshtml"
 
    var method = model is ShortlistStandardViewModel ? "RemoveStandard" : "RemoveFramework";
    

#line default
#line hidden

#line 43 "..\..\Views\Dashboard\Overview.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink(
    "Delete",
    method,
    "ShortList",
    new { id = model.Id },
    new
    {
        @class = "delete-link",
        data_apprenticeship = model.Id,
        data_apprenticeship_type = method,
        rel = "nofollow"
    }));


#line default
#line hidden

#line 54 "..\..\Views\Dashboard\Overview.cshtml"
      


#line default
#line hidden
});

#line 55 "..\..\Views\Dashboard\Overview.cshtml"
}
#line default
#line hidden

#line 57 "..\..\Views\Dashboard\Overview.cshtml"
public System.Web.WebPages.HelperResult GetShortlistItem(IEnumerable<IShortlistApprenticeshipViewModel> apprenticeships)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 58 "..\..\Views\Dashboard\Overview.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"shortlist\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"heading-medium\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            Apprenticeship training\r\n        </h2>\r\n\r\n        <ol");

WriteLiteralTo(__razor_helper_writer, " class=\"apprenticeship-items\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 65 "..\..\Views\Dashboard\Overview.cshtml"
            

#line default
#line hidden

#line 65 "..\..\Views\Dashboard\Overview.cshtml"
             foreach (var apprenticeship in apprenticeships)
            {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                <li");

WriteLiteralTo(__razor_helper_writer, " class=\"apprenticeship-item\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <span");

WriteLiteralTo(__razor_helper_writer, " class=\"apprenticeship-title\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                        ");


#line 69 "..\..\Views\Dashboard\Overview.cshtml"
WriteTo(__razor_helper_writer, GetLink(apprenticeship));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                    </span>\r\n                    <span");

WriteLiteralTo(__razor_helper_writer, " class=\"action\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                        ");


#line 72 "..\..\Views\Dashboard\Overview.cshtml"
WriteTo(__razor_helper_writer, GetDeleteLink(apprenticeship));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                    </span>\r\n");


#line 74 "..\..\Views\Dashboard\Overview.cshtml"
                    

#line default
#line hidden

#line 74 "..\..\Views\Dashboard\Overview.cshtml"
                     if (apprenticeship.Providers.Any())
                    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"providers\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n\r\n                            <h3");

WriteLiteralTo(__razor_helper_writer, " class=\"heading-small\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                                Training providers\r\n                          " +
"  </h3>\r\n");


#line 81 "..\..\Views\Dashboard\Overview.cshtml"
                            

#line default
#line hidden

#line 81 "..\..\Views\Dashboard\Overview.cshtml"
                             foreach (var provider in apprenticeship.Providers.OrderBy(m => m.Name))
                            {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                                <ol>\r\n                                    <li");

WriteLiteralTo(__razor_helper_writer, " class=\"provider-item\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                                        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"provider-title\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                                            ");


#line 86 "..\..\Views\Dashboard\Overview.cshtml"
              WriteTo(__razor_helper_writer, Html.RenderAIfExists(provider.Name, provider.Url, string.Empty));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                                        </span>\r\n                              " +
"          <span");

WriteLiteralTo(__razor_helper_writer, " class=\"action\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                                             ");


#line 89 "..\..\Views\Dashboard\Overview.cshtml"
                WriteTo(__razor_helper_writer, apprenticeship is ShortlistStandardViewModel ?
                                                Html.ActionLink(
                                                    "Delete",
                                                    "RemoveStandardProvider",
                                                    "ShortList",
                                                    new
                                                    {
                                                        apprenticeshipId = apprenticeship.Id,
                                                        providerId = provider.Id,
                                                        locationId = provider.LocationId
                                                    },
                                                    new
                                                    {
                                                        @class = "provider-delete-link",
                                                        data_provider = provider.Id,
                                                        data_apprenticeship = apprenticeship.Id,
                                                        data_apprenticeship_type = "Standard",
                                                        data_location = provider.LocationId,
                                                        rel = "nofollow"
                                                    }) :
                                                Html.ActionLink(
                                                    "Delete",
                                                    "RemoveFrameworkProvider",
                                                    "ShortList",
                                                    new
                                                    {
                                                        apprenticeshipId = apprenticeship.Id,
                                                        providerId = provider.Id,
                                                        locationId = provider.LocationId
                                                    },
                                                    new
                                                    {
                                                        @class = "provider-delete-link",
                                                        data_provider = provider.Id,
                                                        data_apprenticeship = apprenticeship.Id,
                                                        data_apprenticeship_type = "Framework",
                                                        data_location = provider.LocationId,
                                                        rel = "nofollow"
                                                    }));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                                        </span>\r\n                              " +
"      </li>\r\n                                </ol>\r\n");


#line 131 "..\..\Views\Dashboard\Overview.cshtml"
                            }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                        </div> \r\n");


#line 133 "..\..\Views\Dashboard\Overview.cshtml"
                    }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                </li>\r\n");


#line 135 "..\..\Views\Dashboard\Overview.cshtml"
            }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        </ol>\r\n    </div>\r\n");


#line 138 "..\..\Views\Dashboard\Overview.cshtml"


#line default
#line hidden
});

#line 138 "..\..\Views\Dashboard\Overview.cshtml"
}
#line default
#line hidden

        public Overview()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Dashboard\Overview.cshtml"
  
    ViewBag.Title = "My Dashboard";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"standard-detail\"");

WriteLiteral(">\r\n    <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 11 "..\..\Views\Dashboard\Overview.cshtml"
   Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </h1>\r\n\r\n");

WriteLiteral("    ");

            
            #line 14 "..\..\Views\Dashboard\Overview.cshtml"
Write(DisplayEmptyShortlistMessage(Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    \r\n");

            
            #line 17 "..\..\Views\Dashboard\Overview.cshtml"
    
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Dashboard\Overview.cshtml"
     if (!Model.Apprenticeships.IsNullOrEmpty())
    {
        
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Dashboard\Overview.cshtml"
   Write(GetShortlistItem(Model.Apprenticeships.OrderBy(m => m.Title)));

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Dashboard\Overview.cshtml"
                                                                      ;
    }

            
            #line default
            #line hidden
WriteLiteral("</main>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
