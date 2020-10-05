using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainTrade.PageObjects.LeftMenuPage
{
    public class LeftMenu
    {
        IWebDriver _driver;
        public LeftMenu(IWebDriver driver)
        {
            this._driver = driver;
        }

        By _logo = By.CssSelector("#app > div.slide-menu > div > div.head > div > div.image > a > img");
        By _main = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.active > a");
        By _exchange = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div:nth-child(2) > a");
        By _index = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div:nth-child(3) > a");
        By _users = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.users.desc > a");
        By _traiders = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.users.desc.open > div > div:nth-child(1) > a");
        By _manufactures = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.users.desc.open > div > div:nth-child(2) > a");
        By _elevators = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.users.desc.open > div > div:nth-child(3) > a");
        By _freightForwarders = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.users.desc.open > div > div:nth-child(4) > a");
        By G_gtes = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.users.desc.open > div > div:nth-child(5) > a");
        By _terminals = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.users.desc.open > div > div:nth-child(6) > a");
        By _holdings = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.users.desc.open > div > div:nth-child(7) > a");
        By _processors = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.users.desc.open > div > div:nth-child(8) > a");
        By _news = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div:nth-child(5) > a");
        By _grainPrices = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div:nth-child(6) > a");
        By _statistics = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div:nth-child(7) > a");
        By _map = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div:nth-child(8) > a");
        By _aboutUs = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.about > a");
        By _contacts = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.about.open > div > div:nth-child(1) > a");
        By _partners = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.about.open > div > div:nth-child(2) > a");
        By _cooperation = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.about.open > div > div:nth-child(3) > a");
        By _advertising = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.about.open > div > div:nth-child(4) > a");
        By _siteMap = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.about.open > div > div:nth-child(5) > a");


        public LeftMenu ClickTheButton(By locator)
        {
            _driver.FindElement(locator).Click();
            return this;
        }
    }
}
