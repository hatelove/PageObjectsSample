using FluentAutomation;
using PageObjectsWithLogin.Tests.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageObjectsWithLogin.Tests.PageObjects
{
    public class WelcomePage : PageObject<WelcomePage>
    {
        public WelcomePage(FluentTest test)
            : base(test)
        {
            Url = string.Format("{0}/{1}", MyTestContext.Domain, "Welcome");
        }

        internal void WelcomeMessage(string welcomeMessage)
        {
            throw new NotImplementedException();
        }
    }
}
