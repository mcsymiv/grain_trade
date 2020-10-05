using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainTrade.PageObjects.LeftMenuPage
{
    public class LeftMenuPage
    {
        IWebDriver _driver;
        public LeftMenuPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public By MenuButton = By.CssSelector("html body noindex div#app.page-wrap div.page-layout.without-padding-top div.header.transparent div.slide-menu_btn");
        public By TitleMain = By.XPath("/html/body/noindex/div/div[2]/div/div[2]/div[1]/div/div[1]/a/div[2]/span");

        public By Exchange = By.XPath("/html/body/noindex/div/div[2]/div/div[2]/div[1]/div/div[2]");
        public By ExchangeTitle = By.CssSelector("html body noindex div#app.page-wrap div.page-layout.without-padding-top div.layout-wrap div.content-wrap.container div.page-content div.page-head div.title-wrap h1.h2-title");
        public By News = By.CssSelector("html body.no-scroll noindex div#app.page-wrap div.slide-menu div.slide-menu-wrap div.body.ps-container.ps-theme-default div.link-list div.items-wrap div.item.active a");
        public By NewsTitle = By.CssSelector("html body noindex div#app.page-wrap div.page-layout.default div.layout-wrap div.content-wrap.container div.page-content div.page-head h1.h2-title");
        public By Prices = By.XPath("/html/body/noindex/div/div[2]/div/div[2]/div[1]/div/div[5]");
        public By PriceTitle = By.CssSelector("html body noindex div#app.page-wrap div.page-layout.default div.layout-wrap div.content-wrap.container div.page-content div.page-head h1.h2-title");
        public By Stats = By.XPath("/html/body/noindex/div/div[2]/div/div[2]/div[1]/div/div[6]");
        public By StatsTitle = By.XPath("/html/body/noindex/div/div[2]/div/div[2]/div[1]/div/div[2]");
        public By Map = By.XPath("/html/body/noindex/div/div[2]/div/div[2]/div[1]/div/div[7]");
        public By MapTitle = By.CssSelector("html body noindex div#app.page-wrap div.page-layout.default div.layout-wrap div.content-wrap.container div.page-content div.page-head h1.h2-title");

        public By Traiders = By.XPath("/html/body/noindex/div/div[2]/div/div[2]/div[1]/div/div[3]/div/div[1]");
        public By TraidersPageTitle = By.CssSelector("html body noindex div#app.page-wrap div.page-layout.default div.layout-wrap div.content-wrap.container div.page-content div.page-head div.page-head-desktop div.title-wrap h2.h2-title");
        public By Manufacturers = By.XPath("/html/body/noindex/div/div[2]/div/div[2]/div[1]/div/div[4]/div/div[2]");
        public By ManufacturersPageTitle = By.CssSelector("html body noindex div#app.page-wrap div.page-layout.default div.layout-wrap div.content-wrap.container div.page-content div.page-head div.page-head-desktop div.title-wrap h2.h2-title");
        public By Elevators = By.XPath("/html/body/noindex/div/div[2]/div/div[2]/div[1]/div/div[4]/div/div[3]");
        public By ElevatorsPageTitle = By.CssSelector("html body noindex div#app.page-wrap div.page-layout.default div.layout-wrap div.content-wrap.container div.page-content div.page-head div.page-head-desktop div.title-wrap h2.h2-title");

        public LeftMenuPage MenuLinkClick(By locator)
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElement(locator)).Click().Perform();
            return this;
        }
        public LeftMenuPage MenuButtonOpen()
        {
            _driver.FindElement(MenuButton).Click();
            return this;
        }
        public string GetElementTitle(By locator)
        {
            return _driver.FindElement(locator).Text;
        }
        public LeftMenuPage ScrollToView(By locator)
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElement(locator)).Perform();
            return this;
        }
    }
}
