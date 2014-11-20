using FluentAutomation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageObjectsWithLogin.Tests.PageObjects
{
    public class GoogleSearchResultsPage : PageObject<GoogleSearchResultsPage>
    {
        public GoogleSearchResultsPage(FluentTest test)
            : base(test)
        {
            
        }

        internal void FindResultsLink(string link)
        {
            throw new NotImplementedException();
        }
    }
}
