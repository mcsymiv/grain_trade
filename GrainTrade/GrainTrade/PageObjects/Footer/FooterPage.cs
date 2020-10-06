using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainTrade.PageObjects.Footer
{
    public class Footer
    {
        IWebDriver _driver;
        public Footer(IWebDriver driver)
        {
            this._driver = driver;
        }

        By _aboutUs = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[1]/ul/li[1]/a");
        By _partners = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[1]/ul/li[2]/a");
        By _cooperation = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[1]/ul/li[3]/a");
        By _contacts = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[1]/ul/li[4]/a");
        By _siteMap = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[1]/ul/li[5]/a");
        By _loginRegistration = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[2]/ul/li[1]/a");
        By _createAnOffer = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[2]/ul/li[2]/a");
        By _exchange = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[2]/ul/li[3]/a");
        By _statistics = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[2]/ul/li[4]/a");
        By _advertising = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[2]/ul/li[5]/a");
        By _listOfMacturers = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[3]/ul/li[1]/a");
        By _agriculturalHoldings = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[3]/ul/li[2]/a");
        By _agriculturalFirms = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[3]/ul/li[3]/a");
        By _farmers = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[3]/ul/li[4]/a");
        By _listOfElevators = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[4]/ul/li[1]/a");
        By _commercialElevators = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[4]/ul/li[2]/a");
        By _farmingElevators = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[4]/ul/li[3]/a");
        By _mixedElevators = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[4]/ul/li[4]/a");
        By _nationalElevators = By.XPath("/html/body/noindex/div/div[1]/div[5]/div[1]/div[4]/ul/li[5]/a");

        public Footer ClickTheButton(By locator)
        {
            _driver.FindElement(locator).Click();
            return this;
        }
    }
}
