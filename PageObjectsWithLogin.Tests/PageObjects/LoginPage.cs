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
        private const string AccountContainer = "#account";
        private const string PasswordContainer = "#password";
        private const string ErrorMessageContainer = "#errorMessage";

        public LoginPage(FluentTest test)
            : base(test)
        {
            Url = string.Format("{0}/{1}", MyTestContext.Domain, "Login");
        }

        internal void Account(string account)
        {
            I.Enter(account).In(AccountContainer);
        }

        internal void Password(string password)
        {
            I.Enter(password).In(PasswordContainer);
        }

        internal void Login()
        {
            I.Press("{ENTER}");
        }

        internal void ShowMessage(string errorMessage)
        {
            I.Assert.Text(errorMessage).In(ErrorMessageContainer);
        }
    }
}
