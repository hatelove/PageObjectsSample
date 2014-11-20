using FluentAutomation;
using PageObjectsWithLogin.Tests.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageObjectsWithLogin.Tests.PageObjects
{
    public class LoginPage : PageObject<LoginPage>
    {
        public LoginPage(FluentTest test)
            : base(test)
        {
            Url = string.Format("{0}/{1}", MyTestContext.Domain, "Login");
        }

        internal void Account(string account)
        {
            throw new NotImplementedException();
        }

        internal void Password(string password)
        {
            throw new NotImplementedException();
        }

        internal void Login()
        {
            throw new NotImplementedException();
        }
    }
}
