using FluentAutomation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PageObjectsWithLogin.Tests.PageObjects
{
    public class GoogleSearchResultsPage : PageObject<GoogleSearchResultsPage>
    {
        private const string ResultUrlLink = "a[href='{0}']";

        public GoogleSearchResultsPage(FluentTest test)
            : base(test)
        {
        }

        internal void FindResultsLink(string link)
        {
            I.Assert.Exists(string.Format(ResultUrlLink, link));
        }
    }
}