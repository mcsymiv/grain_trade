using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainTrade.PageObjects
{
    public class HeaderUserNotAuth : Header
    {
        IWebDriver _driver;
        public HeaderUserNotAuth(IWebDriver driver)
        {
            this._driver = driver;
        }

        By _signIn = By.CssSelector("html body noindex div#app.page-wrap div.page-layout.without-padding-top div.header.transparent div.container div.cabinet-links div.auth-wrap div.button.transparent.login-btn");
        public void ClickAuthButton()
        {
            _driver.FindElement(_signIn).Click();
        }
    }
}
