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
        private const string welcomeMessageContainer= "#message";
        public WelcomePage(FluentTest test)
            : base(test)
        {
            Url = string.Format("{0}/{1}", MyTestContext.Domain, "Welcome");
        }

        internal void CheckAt()
        {
            I.Assert.Url(this.Url);
        }

        internal void WelcomeMessage(string welcomeMessage)
        {
            I.Assert.Text(welcomeMessage).In(welcomeMessageContainer);
        }
    }
}
