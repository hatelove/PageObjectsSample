using FluentAutomation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PageObjectsWithLogin.Tests.PageObjects
{
    public class GoogleSearchPage : PageObject<GoogleSearchPage>
    {
        private const string SearchTextContainer = "#lst-ib";

        public GoogleSearchPage(FluentTest test)
            : base(test)
        {
            Url = "https://www.google.com";
        }

        internal void Search(string keywords)
        {
            I.Enter(keywords).In(SearchTextContainer);
            I.Press("{ENTER}");
        }
    }
}