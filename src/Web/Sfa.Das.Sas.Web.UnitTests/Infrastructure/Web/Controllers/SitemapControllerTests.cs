﻿using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Sfa.Das.Sas.Web.Controllers;
using Sfa.Das.Sas.Web.Helpers;
using Sfa.Das.Sas.Web.Services;

namespace Sfa.Das.Sas.Web.UnitTests.Infrastructure.Web.Controllers
{
    [TestClass]
    public class SitemapControllerTests
    {
        [TestMethod]
        public void ShouldGenerateSitemapXmlGivenProviderList()
        {
            var mockContext = new Mock<HttpContextBase>();
            var mockRequest = new Mock<HttpRequestBase>();
            var prn1 = 11;
            var prn2 = 2;
            var name1 = "eleven";
            var name2 = "a-two";


            const string dummyDomain = "http://test.com";
            mockRequest.Setup(x => x.Url).Returns(new System.Uri(dummyDomain + "/dummy-path-and-query"));

            mockContext
                .Setup(c => c.Request)
                .Returns(mockRequest.Object);

            var mockProviderService = new Mock<IProviderService>();
            mockProviderService.Setup(x => x.GetProviderList())
                .Returns(
                new Dictionary<long, string>
                {
                    { prn1, name1 },
                    { prn2, name2 }
                });

            var mockStringUrlHelper = new Mock<IStringUrlHelper>();
            mockStringUrlHelper.Setup(x => x.ModifyStringForUrlUsage(It.IsAny<string>()))
                .Returns<string>(x => x);

            var sitemapController = new SitemapController(null,mockProviderService.Object, mockStringUrlHelper.Object);
            sitemapController.ControllerContext = new ControllerContext(mockContext.Object, new RouteData(), sitemapController);
            var result = (ContentResult)sitemapController.Providers();

            var expectedResult = $@"<urlset xmlns=""http://www.sitemaps.org/schemas/sitemap/0.9"">
  <url>
    <loc>
      {dummyDomain}/provider/{prn1}/{name1}
    </loc>
  </url>
  <url>
    <loc>
      {dummyDomain}/provider/{prn2}/{name2}
    </loc>
  </url>
</urlset>";

           Assert.AreEqual(result.Content, expectedResult,"The xml returned was not as expected");
           Assert.AreEqual(result.ContentType, "text/xml", "The content type was not set as xml");
        }
    }
}