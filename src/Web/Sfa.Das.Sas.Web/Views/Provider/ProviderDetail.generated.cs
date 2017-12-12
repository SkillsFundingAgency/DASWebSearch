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
    
    #line 1 "..\..\Views\Provider\ProviderDetail.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Provider\ProviderDetail.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/ProviderDetail.cshtml")]
    public partial class ProviderDetail : System.Web.Mvc.WebViewPage<ProviderDetailViewModel>
    {

#line 156 "..\..\Views\Provider\ProviderDetail.cshtml"
public System.Web.WebPages.HelperResult CreateProgressBar(string message, int progress)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 157 "..\..\Views\Provider\ProviderDetail.cshtml"
 
if (progress > 0)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"progress-container\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"progressbar\"");

WriteAttributeTo(__razor_helper_writer, "style", Tuple.Create(" style=\"", 7039), Tuple.Create("\"", 7064)
, Tuple.Create(Tuple.Create("", 7047), Tuple.Create("width:", 7047), true)

#line 161 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create(" ", 7053), Tuple.Create<System.Object, System.Int32>(progress

#line default
#line hidden
, 7054), false)
, Tuple.Create(Tuple.Create("", 7063), Tuple.Create("%", 7063), true)
);

WriteLiteralTo(__razor_helper_writer, "></div>\r\n        </div>\r\n");


#line 163 "..\..\Views\Provider\ProviderDetail.cshtml"
}


#line default
#line hidden
});

#line 164 "..\..\Views\Provider\ProviderDetail.cshtml"
}
#line default
#line hidden

        public ProviderDetail()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Provider\ProviderDetail.cshtml"
  
    ViewBag.Title = "Provider Details";
    ViewBag.Description = "";

            
            #line default
            #line hidden
WriteLiteral("\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"provider-detail\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(" id=\"provider-name\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 13 "..\..\Views\Provider\ProviderDetail.cshtml"
           Write(Model.ProviderName);

            
            #line default
            #line hidden
WriteLiteral(" \r\n");

            
            #line 14 "..\..\Views\Provider\ProviderDetail.cshtml"
                
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Provider\ProviderDetail.cshtml"
                 if (@Model.NationalProvider)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span");

WriteLiteral(" class=\"tag tag-national\"");

WriteLiteral(">National</span>\r\n");

            
            #line 17 "..\..\Views\Provider\ProviderDetail.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </h1>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <dl");

WriteLiteral(" class=\"data-list--provider data-list--compact\"");

WriteLiteral(">\r\n");

            
            #line 24 "..\..\Views\Provider\ProviderDetail.cshtml"
                
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Provider\ProviderDetail.cshtml"
                 if (!string.IsNullOrEmpty(Model.TradingNames))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <dt>Trading names:</dt>\r\n");

WriteLiteral("                    <dd");

WriteLiteral(" id=\"trading-names\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\Provider\ProviderDetail.cshtml"
                                      Write(Model.TradingNames);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n");

            
            #line 28 "..\..\Views\Provider\ProviderDetail.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <dt>UKPRN:</dt>\r\n                <dd>");

            
            #line 30 "..\..\Views\Provider\ProviderDetail.cshtml"
               Write(Model.UkPrn);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n                <dt>About this Provider</dt>\r\n                \r\n          " +
"          \r\n            </dl>\r\n");

            
            #line 35 "..\..\Views\Provider\ProviderDetail.cshtml"
            
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Provider\ProviderDetail.cshtml"
             if (string.IsNullOrEmpty(Model.MarketingInfo))
            {

            
            #line default
            #line hidden
WriteLiteral("                <span>There is no marketing information available about this prov" +
"ider.</span>\r\n");

            
            #line 38 "..\..\Views\Provider\ProviderDetail.cshtml"
            }
            else
            {
                
            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\Provider\ProviderDetail.cshtml"
           Write(Html.MarkdownToHtml(Model.MarketingInfo));

            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\Provider\ProviderDetail.cshtml"
                                                         
            }

            
            #line default
            #line hidden
WriteLiteral("            \r\n            <br/>\r\n            <br/>\r\n");

            
            #line 46 "..\..\Views\Provider\ProviderDetail.cshtml"
            
            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\Provider\ProviderDetail.cshtml"
             if (Model.ApprenticeshipTrainingSummary != null && Model.ApprenticeshipTrainingSummary.Count > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div>\r\n");

WriteLiteral("                    ");

            
            #line 49 "..\..\Views\Provider\ProviderDetail.cshtml"
               Write(Model.ApprenticeshipTrainingSummary.Count);

            
            #line default
            #line hidden
WriteLiteral(" Apprenticeships offered\r\n                </div>\r\n");

WriteLiteral("                <table>\r\n                    \r\n                    <thead><th>App" +
"renticeship</th><th>Type</th><th>Level</th></thead>\r\n                    <tbody>" +
"\r\n");

            
            #line 55 "..\..\Views\Provider\ProviderDetail.cshtml"
                
            
            #line default
            #line hidden
            
            #line 55 "..\..\Views\Provider\ProviderDetail.cshtml"
                 foreach (var item in Model.ApprenticeshipTrainingSummary.ApprenticeshipTrainingItems)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr>\r\n                        <td>");

            
            #line 58 "..\..\Views\Provider\ProviderDetail.cshtml"
                       Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 59 "..\..\Views\Provider\ProviderDetail.cshtml"
                       Write(item.Type);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 60 "..\..\Views\Provider\ProviderDetail.cshtml"
                       Write(item.Level);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td><a");

WriteLiteral(" href=\"\"");

WriteLiteral(">Details</a></td>\r\n                    </tr>\r\n");

            
            #line 63 "..\..\Views\Provider\ProviderDetail.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                    </tbody>\r\n                </table>\r\n");

            
            #line 66 "..\..\Views\Provider\ProviderDetail.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n        <div");

WriteLiteral(" class=\"column-one-third\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"panel--contact\"");

WriteLiteral(">\r\n                <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">Contact details</h2>\r\n                <dl>\r\n");

            
            #line 72 "..\..\Views\Provider\ProviderDetail.cshtml"
                     
            
            #line default
            #line hidden
            
            #line 72 "..\..\Views\Provider\ProviderDetail.cshtml"
                       var linkProtocol = Model.Website.StartsWith("http") ? string.Empty : "http://";
            
            #line default
            #line hidden
WriteLiteral("\r\n                    <dt");

WriteLiteral(" class=\"apprenticeshipContactTitle\"");

WriteLiteral(">Website:</dt>\r\n                    <dd>\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2768), Tuple.Create("\"", 2802)
            
            #line 75 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 2775), Tuple.Create<System.Object, System.Int32>(linkProtocol
            
            #line default
            #line hidden
, 2775), false)
            
            #line 75 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 2788), Tuple.Create<System.Object, System.Int32>(Model.Website
            
            #line default
            #line hidden
, 2788), false)
);

WriteLiteral(" rel=\"external\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"course-link apprenticeshipContact\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 76 "..\..\Views\Provider\ProviderDetail.cshtml"
                       Write(Html.Raw(Model.ProviderName + " website"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                    </dd>\r\n\r\n");

            
            #line 80 "..\..\Views\Provider\ProviderDetail.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 80 "..\..\Views\Provider\ProviderDetail.cshtml"
                      
                    if (!string.IsNullOrEmpty(Model.Phone))
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <dt");

WriteLiteral(" class=\"phone-title\"");

WriteLiteral(">Phone number:</dt>\r\n");

WriteLiteral("                        <dd");

WriteLiteral(" id=\"phone\"");

WriteLiteral(" class=\"phone\"");

WriteLiteral(">");

            
            #line 84 "..\..\Views\Provider\ProviderDetail.cshtml"
                                                Write(Html.Raw(Model.Phone));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n");

            
            #line 85 "..\..\Views\Provider\ProviderDetail.cshtml"
                        }
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 87 "..\..\Views\Provider\ProviderDetail.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 87 "..\..\Views\Provider\ProviderDetail.cshtml"
                      
                    if (!string.IsNullOrEmpty(Model.Email))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <dt");

WriteLiteral(" class=\"email-title\"");

WriteLiteral(">Email:</dt>\r\n");

WriteLiteral("                            <dd");

WriteLiteral(" id=\"email\"");

WriteLiteral(" class=\"email\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3558), Tuple.Create("\"", 3594)
, Tuple.Create(Tuple.Create("", 3565), Tuple.Create("mailto:", 3565), true)
            
            #line 91 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 3572), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.Email)
            
            #line default
            #line hidden
, 3572), false)
);

WriteLiteral(">");

            
            #line 91 "..\..\Views\Provider\ProviderDetail.cshtml"
                                                                                            Write(Html.Raw(Model.Email));

            
            #line default
            #line hidden
WriteLiteral("</a></dd>\r\n");

            
            #line 92 "..\..\Views\Provider\ProviderDetail.cshtml"
                        }
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                </dl>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"panel--contact panel--satisfaction\"");

WriteLiteral(">\r\n                <dl>\r\n                    <dt>Employer satisfaction:</dt>\r\n   " +
"                 <dd>\r\n                        <div");

WriteLiteral(" class=\"rating rating--inline\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" id=\"employer-satisfaction\"");

WriteAttribute("class", Tuple.Create(" class=\"", 4008), Tuple.Create("\"", 4050)
, Tuple.Create(Tuple.Create("", 4016), Tuple.Create("rating-", 4016), true)
            
            #line 102 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 4023), Tuple.Create<System.Object, System.Int32>(Model.EmployerSatisfaction
            
            #line default
            #line hidden
, 4023), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 103 "..\..\Views\Provider\ProviderDetail.cshtml"
                           Write(Model.EmployerSatisfactionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n");

WriteLiteral("                            ");

            
            #line 105 "..\..\Views\Provider\ProviderDetail.cshtml"
                       Write(CreateProgressBar(Model.EmployerSatisfactionMessage, (int)Model.EmployerSatisfaction));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </dd>\r\n                    " +
"<dt>Learner satisfaction:</dt>\r\n                    <dd>\r\n                      " +
"  <div");

WriteLiteral(" class=\"rating rating--inline\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" id=\"learner-satisfaction\"");

WriteAttribute("class", Tuple.Create(" class=\"", 4532), Tuple.Create("\"", 4573)
, Tuple.Create(Tuple.Create("", 4540), Tuple.Create("rating-", 4540), true)
            
            #line 111 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 4547), Tuple.Create<System.Object, System.Int32>(Model.LearnerSatisfaction
            
            #line default
            #line hidden
, 4547), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 112 "..\..\Views\Provider\ProviderDetail.cshtml"
                           Write(Model.LearnerSatisfactionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n");

WriteLiteral("                            ");

            
            #line 114 "..\..\Views\Provider\ProviderDetail.cshtml"
                       Write(CreateProgressBar(Model.LearnerSatisfactionMessage, (int)Model.LearnerSatisfaction));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n");

            
            #line 116 "..\..\Views\Provider\ProviderDetail.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 116 "..\..\Views\Provider\ProviderDetail.cshtml"
                         if (!(Model.EmployerSatisfactionMessage == "no data available" && Model.LearnerSatisfactionMessage == "no data available"))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <span");

WriteLiteral(" class=\"satisfaction-source font-small\"");

WriteLiteral(">\r\n                                Source: <a");

WriteLiteral(" href=\"https://www.gov.uk/government/statistical-data-sets/fe-choices-performance" +
"-indicators\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">Skills Funding Agency FE Choices</a>\r\n                            </span>\r\n");

            
            #line 121 "..\..\Views\Provider\ProviderDetail.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </dd>\r\n                </dl>\r\n            </div>\r\n           " +
" <div");

WriteLiteral(" class=\"panel--disclaimer\"");

WriteLiteral(@">
                <h4>Content disclaimer</h4>
                <p>
                    Education and Skills Funding Agency cannot guarantee the accuracy of course information on this site and makes 
                    no representations about the quality of any courses which appear on the site. Education and Skills Funding Agency 
                    is not liable for any losses suffered as a result of any party relying on the course information 
                    provided.
                </p>
            </div>
            <div >
                <details>
                    <summary>Explain Type</summary>
                    <div");

WriteLiteral(" class=\"panel panel-border-narrow\"");

WriteLiteral(@">
                        Type explanation goes here
                    </div>
                </details>
            </div>
            <div>   
                <details>
                    <summary>Explain levels</summary>
                    <div");

WriteLiteral(" class=\"panel panel-border-narrow\"");

WriteLiteral(">\r\n                        <p>Apprenticeships are set at different levels of diff" +
"iculty from the equivalent of GCSE (level 2) up to postgraduate (level 7)</p>\r\n " +
"                       <p><a");

WriteLiteral(" href=\"https://www.gov.uk/what-different-qualification-levels-mean/overview\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" rel=\"external\"");

WriteLiteral(">More about levels</a></p>\r\n                    </div>\r\n                </details" +
">\r\n            </div>\r\n        </div>       \r\n    </div>\r\n</main>\r\n     \r\n\r\n");

        }
    }
}
#pragma warning restore 1591