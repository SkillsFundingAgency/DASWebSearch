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
    
    #line 5 "..\..\Views\Provider\Detail.cshtml"
    using FeatureToggle.Core.Fluent;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Provider\Detail.cshtml"
    using Sfa.Das.Sas.ApplicationServices.FeatureToggles;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Provider\Detail.cshtml"
    using Sfa.Das.Sas.Resources;
    
    #line default
    #line hidden
    using Sfa.Das.Sas.Web;
    
    #line 1 "..\..\Views\Provider\Detail.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Provider\Detail.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/Detail.cshtml")]
    public partial class Detail : System.Web.Mvc.WebViewPage<ApprenticeshipDetailsViewModel>
    {

#line 182 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult ShowTrainingLocation(string title)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 183 "..\..\Views\Provider\Detail.cshtml"
 
if (@Model != null)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"training-location-title\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 186 "..\..\Views\Provider\Detail.cshtml"
          WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");


#line 187 "..\..\Views\Provider\Detail.cshtml"

    if (@Model.DeliveryModes.Count == 1 && @Model.DeliveryModes.Contains("100PercentEmployer"))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteLiteralTo(__razor_helper_writer, " id=\"training-location\"");

WriteLiteralTo(__razor_helper_writer, " class=\"training-location\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            Training takes place at your location\r\n        </dd>\r\n");


#line 193 "..\..\Views\Provider\Detail.cshtml"
    }
    else
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteLiteralTo(__razor_helper_writer, " id=\"training-location\"");

WriteLiteralTo(__razor_helper_writer, " class=\"training-location\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "            ");


#line 197 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, Model.LocationAddressLine);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " \r\n        </dd>\r\n");


#line 199 "..\..\Views\Provider\Detail.cshtml"
    }
}


#line default
#line hidden
});

#line 201 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 203 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult GetStandardPropertyHtml(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 204 "..\..\Views\Provider\Detail.cshtml"
 
if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 9863), Tuple.Create("\"", 9880)

#line 207 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 9871), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 9871), false)
, Tuple.Create(Tuple.Create("", 9874), Tuple.Create("-title", 9874), true)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 207 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 9902), Tuple.Create("\"", 9910)

#line 208 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 9907), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 9907), false)
);

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 9911), Tuple.Create("\"", 9922)

#line 208 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 9919), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 9919), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 208 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, Html.Raw(item));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 209 "..\..\Views\Provider\Detail.cshtml"
}


#line default
#line hidden
});

#line 210 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 212 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult GetEmailPropertyHtml(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 213 "..\..\Views\Provider\Detail.cshtml"
 
if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"email-title\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 216 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 10152), Tuple.Create("\"", 10160)

#line 217 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 10157), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 10157), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"email\"");

WriteLiteralTo(__razor_helper_writer, "><a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 10178), Tuple.Create("\"", 10207)
, Tuple.Create(Tuple.Create("", 10185), Tuple.Create("mailto:", 10185), true)

#line 217 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 10192), Tuple.Create<System.Object, System.Int32>(Html.Raw(item)

#line default
#line hidden
, 10192), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 217 "..\..\Views\Provider\Detail.cshtml"
                                  WriteTo(__razor_helper_writer, Html.Raw(item));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a></dd>\r\n");


#line 218 "..\..\Views\Provider\Detail.cshtml"
}


#line default
#line hidden
});

#line 219 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 221 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult GetStandardPropertyAsLinkHtml(string title, string cssClass, string classTitle, string classIdentifier, string url, string urlTitle = "")
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 222 "..\..\Views\Provider\Detail.cshtml"
 
    if (!string.IsNullOrEmpty(url))
    {
        var linkProtocol = url.StartsWith("http") ? string.Empty : "http://";


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 10527), Tuple.Create("\"", 10546)

#line 226 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 10535), Tuple.Create<System.Object, System.Int32>(classTitle

#line default
#line hidden
, 10535), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 226 "..\..\Views\Provider\Detail.cshtml"
  WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd>\r\n            <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 10589), Tuple.Create("\"", 10613)

#line 228 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 10596), Tuple.Create<System.Object, System.Int32>(linkProtocol

#line default
#line hidden
, 10596), false)

#line 228 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 10609), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 10609), false)
);

WriteLiteralTo(__razor_helper_writer, " rel=\"external\"");

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 10645), Tuple.Create("\"", 10679)

#line 228 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 10653), Tuple.Create<System.Object, System.Int32>(cssClass

#line default
#line hidden
, 10653), false)

#line 228 "..\..\Views\Provider\Detail.cshtml"
      , Tuple.Create(Tuple.Create(" ", 10662), Tuple.Create<System.Object, System.Int32>(classIdentifier

#line default
#line hidden
, 10663), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 229 "..\..\Views\Provider\Detail.cshtml"
                

#line default
#line hidden

#line 229 "..\..\Views\Provider\Detail.cshtml"
                 if (string.IsNullOrEmpty(urlTitle))
                {
                    

#line default
#line hidden

#line 231 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, Html.Raw(url));


#line default
#line hidden

#line 231 "..\..\Views\Provider\Detail.cshtml"
                                  
                }
                else
                {
                    

#line default
#line hidden

#line 235 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, Html.Raw(urlTitle));


#line default
#line hidden

#line 235 "..\..\Views\Provider\Detail.cshtml"
                                       
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </a>\r\n        </dd>\r\n");


#line 239 "..\..\Views\Provider\Detail.cshtml"
    }


#line default
#line hidden
});

#line 240 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 242 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult CreateProgressBar(string message, int progress)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 243 "..\..\Views\Provider\Detail.cshtml"
 
    if (progress > 0)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"progress-container\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"progressbar\"");

WriteAttributeTo(__razor_helper_writer, "style", Tuple.Create(" style=\"", 11125), Tuple.Create("\"", 11150)
, Tuple.Create(Tuple.Create("", 11133), Tuple.Create("width:", 11133), true)

#line 247 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create(" ", 11139), Tuple.Create<System.Object, System.Int32>(progress

#line default
#line hidden
, 11140), false)
, Tuple.Create(Tuple.Create("", 11149), Tuple.Create("%", 11149), true)
);

WriteLiteralTo(__razor_helper_writer, "></div>\r\n        </div>\r\n");


#line 249 "..\..\Views\Provider\Detail.cshtml"
    }


#line default
#line hidden
});

#line 250 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 252 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult GetDeliveryModesHtml(string title, List<string> items, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 253 "..\..\Views\Provider\Detail.cshtml"
 
if (items != null)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"training-structure\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 256 "..\..\Views\Provider\Detail.cshtml"
     WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteLiteralTo(__razor_helper_writer, " id=\"delivery-modes\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        <ul>\r\n");


#line 259 "..\..\Views\Provider\Detail.cshtml"
            

#line default
#line hidden

#line 259 "..\..\Views\Provider\Detail.cshtml"
             if (items.Exists(m => m.Equals("DayRelease")))
            {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                <li");

WriteLiteralTo(__razor_helper_writer, " class=\"day-release\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 261 "..\..\Views\Provider\Detail.cshtml"
          WriteTo(__razor_helper_writer, Html.Raw("day release"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n");


#line 262 "..\..\Views\Provider\Detail.cshtml"
            }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            ");


#line 263 "..\..\Views\Provider\Detail.cshtml"
             if (items.Exists(m => m.Equals("BlockRelease")))
            {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                <li");

WriteLiteralTo(__razor_helper_writer, " class=\"block-release\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 265 "..\..\Views\Provider\Detail.cshtml"
            WriteTo(__razor_helper_writer, Html.Raw("block release"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n");


#line 266 "..\..\Views\Provider\Detail.cshtml"
            }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            ");


#line 267 "..\..\Views\Provider\Detail.cshtml"
             if (items.Exists(m => m.Equals("100PercentEmployer")))
            {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                <li");

WriteLiteralTo(__razor_helper_writer, " class=\"hundred-percent-employer\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 269 "..\..\Views\Provider\Detail.cshtml"
                       WriteTo(__razor_helper_writer, Html.Raw("at your location"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n");


#line 270 "..\..\Views\Provider\Detail.cshtml"
            }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        </ul>\r\n        <details>\r\n            <summary>Explain training options</" +
"summary>\r\n            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"panel panel-border-narrow\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <p>\r\n                    <span");

WriteLiteralTo(__razor_helper_writer, " class=\"bold-small\"");

WriteLiteralTo(__razor_helper_writer, ">Day release:</span> for example one day a week at the training provider\'s locati" +
"on.\r\n                </p>\r\n                <p>\r\n                    <span");

WriteLiteralTo(__razor_helper_writer, " class=\"bold-small\"");

WriteLiteralTo(__razor_helper_writer, ">Block release:</span> for example 3-4 weeks at the training provider\'s location." +
"\r\n                </p>\r\n                <p>\r\n                    <span");

WriteLiteralTo(__razor_helper_writer, " class=\"bold-small\"");

WriteLiteralTo(__razor_helper_writer, ">At your location:</span> the training provider comes to your workplace.\r\n       " +
"         </p>\r\n            </div>\r\n        </details>\r\n    </dd>\r\n");


#line 287 "..\..\Views\Provider\Detail.cshtml"
}


#line default
#line hidden
});

#line 288 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

        public Detail()
        {
        }
        public override void Execute()
        {
            
            #line 8 "..\..\Views\Provider\Detail.cshtml"
  
    ViewBag.Title = Model.Name + " - Apprenticeship Provider";
    ViewBag.Description = "The Find Apprenticeship Training service is for employers in England who want to find training courses for their apprentices and search for training providers.";

            
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

            
            #line 16 "..\..\Views\Provider\Detail.cshtml"
           Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </h1>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-one-third pull-right\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"panel--contact\"");

WriteLiteral(">\r\n                <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">Contact details</h2>\r\n                <dl>\r\n");

WriteLiteral("                    ");

            
            #line 25 "..\..\Views\Provider\Detail.cshtml"
               Write(GetStandardPropertyAsLinkHtml("Website:", "course-link", "apprenticeshipContactTitle", "apprenticeshipContact", Model.Apprenticeship.ApprenticeshipInfoUrl, @Model.Name + "'s website"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 26 "..\..\Views\Provider\Detail.cshtml"
               Write(GetStandardPropertyHtml("Phone number:", "phone", Model.ContactInformation.Phone));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 27 "..\..\Views\Provider\Detail.cshtml"
               Write(GetEmailPropertyHtml("Email:", "email", Model.ContactInformation.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 28 "..\..\Views\Provider\Detail.cshtml"
               Write(GetStandardPropertyAsLinkHtml("Contact page:", "contact-link", "providerContactTitle", "providerContact", Model.ContactInformation.ContactUsUrl, "contact this training provider"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 29 "..\..\Views\Provider\Detail.cshtml"
               Write(ShowTrainingLocation("Address:"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </dl>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n\r\n            <section>\r\n\r\n                <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">Training information</h2>\r\n\r\n                <dl");

WriteLiteral(" class=\"data-list--provider data-list--compact\"");

WriteLiteral(">\r\n                    <dt>Apprenticeship: </dt>\r\n                    <dd>");

            
            #line 41 "..\..\Views\Provider\Detail.cshtml"
                   Write(Model.ApprenticeshipName);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n                    <dt>Level: </dt>\r\n                    <dd>");

            
            #line 43 "..\..\Views\Provider\Detail.cshtml"
                   Write(Model.ApprenticeshipLevel);

            
            #line default
            #line hidden
WriteLiteral(" (equivalent to ");

            
            #line 43 "..\..\Views\Provider\Detail.cshtml"
                                                             Write(EquivalenceLevelService.GetApprenticeshipLevel(Model.ApprenticeshipLevel));

            
            #line default
            #line hidden
WriteLiteral(")</dd>\r\n\r\n");

WriteLiteral("                    ");

            
            #line 45 "..\..\Views\Provider\Detail.cshtml"
               Write(GetDeliveryModesHtml("Training options:", Model.DeliveryModes));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    ");

WriteLiteral("\r\n\r\n                    <dt>Achievement rates: </dt>\r\n                    <dd>\r\n " +
"                       <div");

WriteLiteral(" class=\"rating\"");

WriteLiteral(">\r\n                            <b");

WriteLiteral(" class=\"font-small\"");

WriteLiteral(">Achievement average:</b>\r\n                            <span");

WriteLiteral(" class=\"national-rate\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 53 "..\..\Views\Provider\Detail.cshtml"
                           Write(Model.AchievementRateMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n");

            
            #line 55 "..\..\Views\Provider\Detail.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 55 "..\..\Views\Provider\Detail.cshtml"
                             if (Model.AchievementRateMessage != "no data available")
                            {
                                
            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\Provider\Detail.cshtml"
                           Write(CreateProgressBar(Model.AchievementRateMessage, Model.AchievementRate));

            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\Provider\Detail.cshtml"
                                                                                                       
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </div>\r\n\r\n");

            
            #line 61 "..\..\Views\Provider\Detail.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\Provider\Detail.cshtml"
                         if (Model.AchievementRateMessage != "no data available")
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"rating national-achievement-bar\"");

WriteLiteral(">\r\n                                <b");

WriteLiteral(" class=\"font-small\"");

WriteLiteral(">National average:</b>\r\n                                <span");

WriteLiteral(" class=\"national-rate\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 66 "..\..\Views\Provider\Detail.cshtml"
                               Write(Model.NationalAchievementRateMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </span>\r\n");

WriteLiteral("                                ");

            
            #line 68 "..\..\Views\Provider\Detail.cshtml"
                           Write(CreateProgressBar(Model.NationalAchievementRateMessage, Model.NationalAchievementRate));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n");

            
            #line 70 "..\..\Views\Provider\Detail.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 71 "..\..\Views\Provider\Detail.cshtml"
                         if (Model.AchievementRateMessage != "no data available")
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <details");

WriteLiteral(" class=\"more-information\"");

WriteLiteral(">\r\n                                <summary>Explain achievement rate</summary>\r\n " +
"                               <div");

WriteLiteral(" class=\"panel panel-border-narrow\"");

WriteLiteral(">\r\n                                    <p>Percentage of apprentices who successfu" +
"lly achieved a similar apprenticeship with this training provider.</p>\r\n        " +
"                            <p>Based on the latest data for ");

            
            #line 77 "..\..\Views\Provider\Detail.cshtml"
                                                               Write(Model.OverallCohort);

            
            #line default
            #line hidden
WriteLiteral(" apprentices.</p>\r\n                                    <p");

WriteLiteral(" class=\"font-small\"");

WriteLiteral(">Source: <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4241), Tuple.Create("\"", 4279)
            
            #line 78 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 4248), Tuple.Create<System.Object, System.Int32>(Model.AchievementRateSourceUrl
            
            #line default
            #line hidden
, 4248), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" rel=\"external\"");

WriteLiteral(">Skills Funding Agency apprenticeship achievement rates</a></p>\r\n                " +
"                </div>\r\n                            </details>\r\n");

            
            #line 81 "..\..\Views\Provider\Detail.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </dd>\r\n                </dl>\r\n\r\n                <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">About the apprenticeship: </h3>\r\n");

WriteLiteral("                ");

            
            #line 86 "..\..\Views\Provider\Detail.cshtml"
           Write(Html.MarkdownToHtml(Model.Apprenticeship.ApprenticeshipMarketingInfo));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n            </section>\r\n         \r\n            <section>\r\n                <h2" +
"");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">Provider information</h2>\r\n                <div");

WriteLiteral(" class=\"provider-marketing-info\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 93 "..\..\Views\Provider\Detail.cshtml"
               Write(Html.MarkdownToHtml(Model.ProviderMarketingInfo));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <dl");

WriteLiteral(" class=\"data-list--provider data-list--compact\"");

WriteLiteral(">\r\n                    <dt>Employer satisfaction:</dt>\r\n                    <dd>\r" +
"\n                        <div");

WriteLiteral(" class=\"rating rating--inline\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" id=\"employer-satisfaction\"");

WriteAttribute("class", Tuple.Create(" class=\"", 5247), Tuple.Create("\"", 5289)
, Tuple.Create(Tuple.Create("", 5255), Tuple.Create("rating-", 5255), true)
            
            #line 99 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 5262), Tuple.Create<System.Object, System.Int32>(Model.EmployerSatisfaction
            
            #line default
            #line hidden
, 5262), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 100 "..\..\Views\Provider\Detail.cshtml"
                           Write(Model.EmployerSatisfactionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n");

WriteLiteral("                            ");

            
            #line 102 "..\..\Views\Provider\Detail.cshtml"
                       Write(CreateProgressBar(Model.EmployerSatisfactionMessage, (int)Model.EmployerSatisfaction));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </dd>\r\n                    " +
"<dt>Learner satisfaction:</dt>\r\n                    <dd>\r\n                      " +
"  <div");

WriteLiteral(" class=\"rating rating--inline\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" id=\"learner-satisfaction\"");

WriteAttribute("class", Tuple.Create(" class=\"", 5771), Tuple.Create("\"", 5812)
, Tuple.Create(Tuple.Create("", 5779), Tuple.Create("rating-", 5779), true)
            
            #line 108 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 5786), Tuple.Create<System.Object, System.Int32>(Model.LearnerSatisfaction
            
            #line default
            #line hidden
, 5786), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 109 "..\..\Views\Provider\Detail.cshtml"
                           Write(Model.LearnerSatisfactionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n");

WriteLiteral("                            ");

            
            #line 111 "..\..\Views\Provider\Detail.cshtml"
                       Write(CreateProgressBar(Model.LearnerSatisfactionMessage, (int) Model.LearnerSatisfaction));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n");

            
            #line 113 "..\..\Views\Provider\Detail.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 113 "..\..\Views\Provider\Detail.cshtml"
                         if (!(Model.EmployerSatisfactionMessage == "no data available" && Model.LearnerSatisfactionMessage == "no data available"))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <span");

WriteLiteral(" class=\"satisfaction-source font-small\"");

WriteLiteral(">\r\n                                Source: <a");

WriteAttribute("href", Tuple.Create(" href=\"", 6361), Tuple.Create("\"", 6396)
            
            #line 116 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 6368), Tuple.Create<System.Object, System.Int32>(Model.SatisfactionSourceUrl
            
            #line default
            #line hidden
, 6368), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">Skills Funding Agency FE Choices</a>\r\n                            </span>\r\n");

            
            #line 118 "..\..\Views\Provider\Detail.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </dd>\r\n                    \r\n");

WriteLiteral("                    ");

            
            #line 121 "..\..\Views\Provider\Detail.cshtml"
               Write(GetStandardPropertyHtml("Legal trading name:", "legal-name", Model.LegalName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </dl>\r\n\r\n");

            
            #line 124 "..\..\Views\Provider\Detail.cshtml"
                
            
            #line default
            #line hidden
            
            #line 124 "..\..\Views\Provider\Detail.cshtml"
                 if (Is<NationalProvidersFeature>.Enabled && Model.NationalProvider)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <p");

WriteLiteral(" class=\"national-message\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"tag tag-new\"");

WriteLiteral(">National</span> This training provider is willing to offer apprenticeship traini" +
"ng across England.\r\n                    </p>\r\n");

            
            #line 129 "..\..\Views\Provider\Detail.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 131 "..\..\Views\Provider\Detail.cshtml"
                
            
            #line default
            #line hidden
            
            #line 131 "..\..\Views\Provider\Detail.cshtml"
                 if (Is<FatLevyJourneyFeature>.Enabled)
                {
                    if (Model.IsLevyPayingEmployer.HasValue && Model.IsLevyPayingEmployer.Value && Model.HasNonLevyContract == false)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <p");

WriteLiteral(" class=\"detail-highlight\"");

WriteLiteral(">\r\n                            Only levy paying employers can work with this prov" +
"ider\r\n                        </p>\r\n");

            
            #line 138 "..\..\Views\Provider\Detail.cshtml"
                    }

                    if (Model.HasParentCompanyGuarantee)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <p");

WriteLiteral(" class=\"detail-highlight\"");

WriteLiteral(">\r\n                            Provider is supported by a parent company guarante" +
"e\r\n                        </p>\r\n");

            
            #line 145 "..\..\Views\Provider\Detail.cshtml"
                    }

                    if (Model.IsNewProvider)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <p");

WriteLiteral(" class=\"detail-highlight\"");

WriteLiteral(">\r\n                            New organisation with no financial track record\r\n " +
"                       </p>\r\n");

            
            #line 152 "..\..\Views\Provider\Detail.cshtml"
                    }
                }

            
            #line default
            #line hidden
WriteLiteral("                <p");

WriteLiteral(" class=\"content-source\"");

WriteLiteral(">\r\n                    Content maintained by ");

            
            #line 155 "..\..\Views\Provider\Detail.cshtml"
                                     Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </p>\r\n            </section>\r\n            \r\n            <div");

WriteLiteral(" class=\"survey\"");

WriteLiteral(">\r\n                <h2");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(@">
                    Give us your feedback
                </h2>
                <p>
                    This is a new service and your feedback will help us improve it.<br />
                    Use the link below to take part in a short survey.
                </p>
                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 8540), Tuple.Create("\"", 8563)
            
            #line 167 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 8547), Tuple.Create<System.Object, System.Int32>(Model.SurveyUrl
            
            #line default
            #line hidden
, 8547), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Take the survey</a>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"provider-disclaimer\"");

WriteLiteral(">\r\n                <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(@">Content disclaimer</h3>
                <p>
                    Skills Funding Agency cannot guarantee the accuracy of course information on this site and makes no representations about the quality of any courses which appear on the site. Skills Funding Agency is not liable for any losses suffered as a result of any party relying on the course information provided.
                </p>
            </div>
        </div>
    </div>
  
</main>



");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
