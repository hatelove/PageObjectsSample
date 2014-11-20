using FluentAutomation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageObjectsWithLogin.Tests.PageObjects
{
    public class GoogleSearchPage : PageObject<GoogleSearchPage>
    {
        public GoogleSearchPage(FluentTest test)
            : base(test)
        {
            Url = "http://https://www.google.com";
        }

        internal void Search(string keywords)
        {
            throw new NotImplementedException();
        }
    }
}
