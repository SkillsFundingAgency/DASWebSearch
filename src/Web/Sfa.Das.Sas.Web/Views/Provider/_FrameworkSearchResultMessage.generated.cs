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
    
    #line 1 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/_FrameworkSearchResultMessage.cshtml")]
    public partial class FrameworkSearchResultMessage : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.Web.ViewModels.ProviderFrameworkSearchResultViewModel>
    {

#line 32 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
public System.Web.WebPages.HelperResult  RenderMessage()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 33 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <p");

WriteLiteralTo(__razor_helper_writer, " class=\"small-btm-margin\"");

WriteLiteralTo(__razor_helper_writer, ">\n");


#line 35 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
        

#line default
#line hidden

#line 35 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
         if (Model.TotalResults > 1)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            ");

WriteLiteralTo(__razor_helper_writer, "There are <b>");


#line 37 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
 WriteTo(__razor_helper_writer, Model.TotalResults);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b> training options for the <b>");


#line 37 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
                                                     WriteTo(__razor_helper_writer, Model.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ", level ");


#line 37 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
                                                                         WriteTo(__razor_helper_writer, Model.FrameworkLevel);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b> apprenticeship.");

WriteLiteralTo(__razor_helper_writer, "\n");


#line 38 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            ");

WriteLiteralTo(__razor_helper_writer, "There is <b>1</b> training option for the <b>");


#line 41 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
                                 WriteTo(__razor_helper_writer, Model.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ", level ");


#line 41 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
                                                     WriteTo(__razor_helper_writer, Model.FrameworkLevel);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b> apprenticeship.");

WriteLiteralTo(__razor_helper_writer, "\n");


#line 42 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </p>\n");

WriteLiteralTo(__razor_helper_writer, "    <p>\n        Results are ordered by distance from \'<b>");


#line 45 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
                   WriteTo(__razor_helper_writer, Model.PostCode.FormatPostcode());


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b>\'.\n    </p>\n");


#line 47 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"


#line default
#line hidden
});

#line 47 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
}
#line default
#line hidden

#line 49 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
public System.Web.WebPages.HelperResult  RenderAllMessage()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 50 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <p");

WriteLiteralTo(__razor_helper_writer, " class=\"small-btm-margin\"");

WriteLiteralTo(__razor_helper_writer, ">\n");


#line 52 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
        

#line default
#line hidden

#line 52 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
         if (Model.TotalResults > 1)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            ");

WriteLiteralTo(__razor_helper_writer, "There are <b>");


#line 54 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
 WriteTo(__razor_helper_writer, Model.TotalResults);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b> training options for the <b>");


#line 54 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
                                                     WriteTo(__razor_helper_writer, Model.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ", level ");


#line 54 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
                                                                         WriteTo(__razor_helper_writer, Model.FrameworkLevel);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b> apprenticeship in England.");

WriteLiteralTo(__razor_helper_writer, "\n");


#line 55 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            ");

WriteLiteralTo(__razor_helper_writer, "There is <b>1</b> training option for the <b>");


#line 58 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
                                 WriteTo(__razor_helper_writer, Model.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ", level ");


#line 58 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
                                                     WriteTo(__razor_helper_writer, Model.FrameworkLevel);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b> apprenticeship in England.");

WriteLiteralTo(__razor_helper_writer, "\n");


#line 59 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </p>\n");

WriteLiteralTo(__razor_helper_writer, "    <p");

WriteLiteralTo(__razor_helper_writer, " class=\"small-btm-margin\"");

WriteLiteralTo(__razor_helper_writer, ">\n        Results are ordered by distance from \'<b>");


#line 62 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
                   WriteTo(__razor_helper_writer, Model.PostCode.FormatPostcode());


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b>\'.\n    </p>\n");


#line 64 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"


#line default
#line hidden
});

#line 64 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
}
#line default
#line hidden

        public FrameworkSearchResultMessage()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"result-message\"");

WriteLiteral(">\n");

            
            #line 4 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
    
            
            #line default
            #line hidden
            
            #line 4 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
     if (Model.HasError)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p>\n            There was a problem performing a search. Try again later." +
"\n        </p>\n");

            
            #line 9 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
    }
    else if (Model.TotalResults > 0 && Model.ShowAll)
    {
        
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
   Write(RenderAllMessage());

            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
                           
    }
    else if (Model.TotalResults > 0)
    {
        
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
   Write(RenderMessage());

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
                        
    }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 19 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
    
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
     if (Model.TotalResults > 0 && Model.NationalProviders != null && Model.NationalProviders.Count > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p>\n            Results labelled <span");

WriteLiteral(" class=\"tag tag-national\"");

WriteLiteral(">National</span> are training options run by providers who are willing to offer t" +
"raining across England.\n        </p>\n");

            
            #line 24 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 26 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
    
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
     if (Model.IsLevyPayingEmployer == false)
    {
        
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
   Write(Html.Partial("_RoatpNonLevyResultsMessage"));

            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Provider\_FrameworkSearchResultMessage.cshtml"
                                                    
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n");

WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
