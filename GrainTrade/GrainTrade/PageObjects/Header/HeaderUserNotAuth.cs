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

        By _signIn = By.XPath("/html/body/noindex/div/div[1]/div[1]/div[4]/div[2]/div/div/a");
        public void ClickAuthButton()
        {
            _driver.FindElement(_signIn).Click();
        }
    }
}
