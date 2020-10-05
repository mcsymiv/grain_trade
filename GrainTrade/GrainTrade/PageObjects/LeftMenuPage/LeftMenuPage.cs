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

        By Logo = By.CssSelector("#app > div.slide-menu > div > div.head > div > div.image > a > img");
        By Main = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.active > a");
        By Exchange = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div:nth-child(2) > a");
        By Index = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div:nth-child(3) > a");
        By Users = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.users.desc > a");
        By Traiders = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.users.desc.open > div > div:nth-child(1) > a");
        By Manufacturer = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.users.desc.open > div > div:nth-child(2) > a");
        By Elevators = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.users.desc.open > div > div:nth-child(3) > a");
        By FreightForwarders = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.users.desc.open > div > div:nth-child(4) > a");
        By Gates = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.users.desc.open > div > div:nth-child(5) > a");
        By Terminals = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.users.desc.open > div > div:nth-child(6) > a");
        By Holdings = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.users.desc.open > div > div:nth-child(7) > a");
        By Processors = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.users.desc.open > div > div:nth-child(8) > a");
        By News = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div:nth-child(5) > a");
        By GrainPrices = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div:nth-child(6) > a");
        By Statistics = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div:nth-child(7) > a");
        By Map = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div:nth-child(8) > a");
        By AboutUs = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.about > a");
        By Contacts = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.about.open > div > div:nth-child(1) > a");
        By Partners = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.about.open > div > div:nth-child(2) > a");
        By Cooperation = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.about.open > div > div:nth-child(3) > a");
        By Advertising = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.about.open > div > div:nth-child(4) > a");
        By SiteMap = By.CssSelector("#app > div.slide-menu > div > div.body.ps-container.ps-theme-default.ps-active-y > div.link-list > div > div.item.about.open > div > div:nth-child(5) > a");


        public LeftMenu ClickTheButton(By locator)
        {
            _driver.FindElement(locator).Click();
            return this;
        }
    }
}
