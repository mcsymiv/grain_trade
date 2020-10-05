using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
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
        public By ExchangeLink = By.XPath("/html/body/noindex/div/div[1]/div[1]/div[4]/div[1]/div[2]/ul/li[1]/a");
        public By ExchangePageTitle = By.CssSelector("html body noindex div#app.page-wrap div.page-layout.without-padding-top div.layout-wrap div.content-wrap.container div.page-content div.page-head div.title-wrap h1.h2-title");
        public By NewsLink = By.XPath("/html/body/noindex/div/div[1]/div[1]/div[4]/div[1]/div[2]/ul/li[2]");
        public By NewsPageTitle = By.CssSelector("html body noindex div#app.page-wrap div.page-layout.default div.layout-wrap div.content-wrap.container div.page-content div.page-head h1.h2-title");
        public By PriceLink = By.XPath("/html/body/noindex/div/div[1]/div[1]/div[4]/div[1]/div[2]/ul/li[3]/a");
        public By PricePageTitle = By.XPath("/");

        public void ClickAuthButton()
        {
            _driver.FindElement(_signIn).Click();
        }
        public HeaderUserNotAuth ClickOnHeaderLinkAction(By locator)
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElement(locator)).Click().Perform();
            _driver.FindElement(locator).Click();
            return this;
        }
        public string GetPageTitle(By locator)
        {
            return _driver.FindElement(locator).Text;
        }
    }
}
