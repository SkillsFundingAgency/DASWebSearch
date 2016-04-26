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

namespace Sfa.Eds.Das.Web.Views.Apprenticeship
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
    
    #line 1 "..\..\Views\Apprenticeship\Standard.cshtml"
    using Resources = Sfa.Eds.Das.Resources.EquivalenceLevels;
    
    #line default
    #line hidden
    using Sfa.Eds.Das.Web;
    
    #line 2 "..\..\Views\Apprenticeship\Standard.cshtml"
    using Sfa.Eds.Das.Web.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/Standard.cshtml")]
    public partial class Standard : System.Web.Mvc.WebViewPage<Sfa.Eds.Das.Web.ViewModels.StandardViewModel>
    {

#line 93 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult CreateSearchForm(string cssClasses)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 94 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    using (Html.BeginForm("StandardResults", "Provider", FormMethod.Get, new { @class = $"search-box {cssClasses}" }))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"heading-medium\"");

WriteLiteralTo(__razor_helper_writer, ">Find training providers for this apprenticeship</h2>\r\n");

WriteLiteralTo(__razor_helper_writer, "                <div");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 4311), Tuple.Create("\"", 4364)
, Tuple.Create(Tuple.Create("", 4319), Tuple.Create("form-group", 4319), true)

#line 98 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create(" ", 4329), Tuple.Create<System.Object, System.Int32>(@Model.HasError ? " error" : ""

#line default
#line hidden
, 4330), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <label");

WriteLiteralTo(__razor_helper_writer, " class=\"form-label\"");

WriteLiteralTo(__razor_helper_writer, " for=\"postcode\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                        Enter a full postcode.\r\n                        <p>\r\n");


#line 102 "..\..\Views\Apprenticeship\Standard.cshtml"
                            

#line default
#line hidden

#line 102 "..\..\Views\Apprenticeship\Standard.cshtml"
                              
                                Html.RenderPartial("_BlankFieldErrorMessage");
                            

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                        </p>\r\n                    </label>\r\n                   " +
" <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"apprenticeshipid\"");

WriteLiteralTo(__razor_helper_writer, " class=\"text-box form-control\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 4805), Tuple.Create("\"", 4830)

#line 107 "..\..\Views\Apprenticeship\Standard.cshtml"
                      , Tuple.Create(Tuple.Create("", 4813), Tuple.Create<System.Object, System.Int32>(Model.StandardId

#line default
#line hidden
, 4813), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"search\"");

WriteLiteralTo(__razor_helper_writer, " name=\"PostCode\"");

WriteLiteralTo(__razor_helper_writer, " class=\"text-box form-control postcode-search-box\"");

WriteLiteralTo(__razor_helper_writer, " maxlength=\"200\"");

WriteLiteralTo(__razor_helper_writer, " placeholder=\"\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                </div>\r\n");

WriteLiteralTo(__razor_helper_writer, "                <input");

WriteLiteralTo(__razor_helper_writer, " class=\"button margin-top-x2 postcode-search-button\"");

WriteLiteralTo(__razor_helper_writer, " id=\"submit-postcode2\"");

WriteLiteralTo(__razor_helper_writer, " type=\"submit\"");

WriteLiteralTo(__razor_helper_writer, " value=\"Search\"");

WriteLiteralTo(__razor_helper_writer, " />\r\n");


#line 111 "..\..\Views\Apprenticeship\Standard.cshtml"
    }


#line default
#line hidden
});

#line 112 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 114 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetStandardDetailItem(string title, string item, string unit = "")
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 115 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    if (!string.IsNullOrEmpty(item))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <dt>");


#line 118 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "                <dd>");


#line 119 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, item);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 119 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, unit);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 120 "..\..\Views\Apprenticeship\Standard.cshtml"
    }


#line default
#line hidden
});

#line 121 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 123 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetStandardLevel(string item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 124 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    if (!string.IsNullOrEmpty(item))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>Level</dt>\r\n");


#line 128 "..\..\Views\Apprenticeship\Standard.cshtml"
        var equivalence = string.Empty;
        switch (int.Parse(@item))
        {
            case 1:
                equivalence = @Resources.FirstLevel;
                break;
            case 2:
                equivalence = @Resources.SecondLevel;
                break;
            case 3:
                equivalence = @Resources.ThirdLevel;
                break;
            case 4:
                equivalence = @Resources.FourthLevel;
                break;
            case 5:
                equivalence = @Resources.FifthLevel;
                break;
            case 6:
                equivalence = @Resources.SixthLevel;
                break;
            case 7:
                equivalence = @Resources.SeventhLevel;
                break;
            case 8:
                equivalence = @Resources.EighthLevel;
                break;
            default:
                break;

        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteLiteralTo(__razor_helper_writer, " id=\"level\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 159 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, item);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " (equivalent to ");


#line 159 "..\..\Views\Apprenticeship\Standard.cshtml"
              WriteTo(__razor_helper_writer, equivalence);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ")</dd>\r\n");


#line 160 "..\..\Views\Apprenticeship\Standard.cshtml"
    }


#line default
#line hidden
});

#line 161 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 163 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetStandardProperty(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 164 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
    {



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 168 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 6668), Tuple.Create("\"", 6676)

#line 169 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 6673), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 6673), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 169 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, Html.MarkdownToHtml(item));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 170 "..\..\Views\Apprenticeship\Standard.cshtml"

    }


#line default
#line hidden
});

#line 172 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 174 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetDocumentItem(string pdfUrl, string title)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 175 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    if (!string.IsNullOrEmpty(title))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <li>\r\n                <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 6864), Tuple.Create("\"", 6878)

#line 179 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 6871), Tuple.Create<System.Object, System.Int32>(pdfUrl

#line default
#line hidden
, 6871), false)
);

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                    ");


#line 180 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                </a>\r\n            </li>\r\n");


#line 183 "..\..\Views\Apprenticeship\Standard.cshtml"
    }


#line default
#line hidden
});

#line 184 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

        public Standard()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Apprenticeship\Standard.cshtml"
  
    ViewBag.Title = "Standard - " + @Model.Title;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"standard-detail\"");

WriteLiteral(">\r\n\r\n    <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 12 "..\..\Views\Apprenticeship\Standard.cshtml"
   Write(Html.RenderAIfExists(@Model.SearchResultLink?.Title, @Model.SearchResultLink?.Url, "link-back"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <div>\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 20 "..\..\Views\Apprenticeship\Standard.cshtml"
               Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h1>\r\n                    <div");

WriteLiteral(" class=\"standard-result-summary\"");

WriteLiteral(@">
                        This is an apprenticeship standard developed by a group of employers. It sets out what the apprentice needs to achieve and how they will be assessed.
                    </div>
            </div>
        </div>


        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"related-container\"");

WriteLiteral(">\r\n                <aside");

WriteLiteral(" class=\"related\"");

WriteLiteral(">\r\n");

            
            #line 32 "..\..\Views\Apprenticeship\Standard.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Apprenticeship\Standard.cshtml"
                     using (Html.BeginForm("StandardResults", "Provider", FormMethod.Get, new { @class = "search-box hidden-for-mobile postcode-form-top" }))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">Find training providers for this apprenticeship</h2>\r\n");

WriteLiteral("                        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1340), Tuple.Create("\"", 1393)
, Tuple.Create(Tuple.Create("", 1348), Tuple.Create("form-group", 1348), true)
            
            #line 35 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create(" ", 1358), Tuple.Create<System.Object, System.Int32>(@Model.HasError ? " error" : ""
            
            #line default
            #line hidden
, 1359), false)
);

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(" for=\"postcode\"");

WriteLiteral(">\r\n                                Enter a full postcode.\r\n                      " +
"          <p>\r\n");

            
            #line 39 "..\..\Views\Apprenticeship\Standard.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Apprenticeship\Standard.cshtml"
                                      
                                        Html.RenderPartial("_BlankFieldErrorMessage");
                                    
            
            #line default
            #line hidden
WriteLiteral("\r\n                                </p>\r\n                            </label>\r\n   " +
"                         <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"apprenticeshipid\"");

WriteLiteral(" name=\"apprenticeshipid\"");

WriteLiteral(" class=\"text-box form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1928), Tuple.Create("\"", 1953)
            
            #line 44 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                    , Tuple.Create(Tuple.Create("", 1936), Tuple.Create<System.Object, System.Int32>(Model.StandardId
            
            #line default
            #line hidden
, 1936), false)
);

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"search\"");

WriteLiteral(" id=\"postcode\"");

WriteLiteral(" name=\"PostCode\"");

WriteLiteral(" class=\"text-box form-control postcode-search-box\"");

WriteLiteral(" maxlength=\"200\"");

WriteLiteral(" placeholder=\"\"");

WriteLiteral(">\r\n                        </div>\r\n");

WriteLiteral("                        <input");

WriteLiteral(" class=\"button margin-top-x2 postcode-search-button\"");

WriteLiteral(" id=\"submit-postcode\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Search\"");

WriteLiteral(" />\r\n");

            
            #line 48 "..\..\Views\Apprenticeship\Standard.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </aside>\r\n                 </div>\r\n\r\n            </div>\r\n  " +
"      </div>\r\n\r\n        <section>\r\n            <header>\r\n                <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\r\n                    Summary of this apprenticeship standard\r\n                <" +
"/h2>\r\n            </header>\r\n            <dl");

WriteLiteral(" class=\"data-list\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 63 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("Overview of role", "overview", Model.OverviewOfRole));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 64 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardLevel(@Model.NotionalEndLevel.ToString()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 65 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("Typical length", "length", @Model.TypicalLengthMessage));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 66 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("Entry requirements", "entry-requirements", Model.EntryRequirements));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 67 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("What apprentices will learn", "will-learn", Model.WhatApprenticesWillLearn));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 68 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("Qualifications", "qualifications", Model.Qualifications));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 69 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("Professional registration", "professional-registration", Model.ProfessionalRegistration, true));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dl>\r\n\r\n");

            
            #line 72 "..\..\Views\Apprenticeship\Standard.cshtml"
            
            
            #line default
            #line hidden
            
            #line 72 "..\..\Views\Apprenticeship\Standard.cshtml"
             if (!string.IsNullOrEmpty($"{Model.AssessmentPlanPdfUrlTitle}{Model.StandardPdfUrlTitle}"))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"panel-indent panel-indent-info\"");

WriteLiteral(">\r\n                    <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\r\n                        Documents\r\n                    </h2>\r\n                " +
"    <ul>\r\n");

WriteLiteral("                        ");

            
            #line 79 "..\..\Views\Apprenticeship\Standard.cshtml"
                   Write(GetDocumentItem(@Model.StandardPdf, "Standard"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 80 "..\..\Views\Apprenticeship\Standard.cshtml"
                   Write(GetDocumentItem(@Model.AssessmentPlanPdf, "Assessment Plan"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </ul>\r\n                </div>\r\n");

            
            #line 83 "..\..\Views\Apprenticeship\Standard.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            <hr />\r\n\r\n");

WriteLiteral("            ");

            
            #line 87 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(CreateSearchForm("postcode-form-bottom"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        </section>\r\n\r\n</main>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
