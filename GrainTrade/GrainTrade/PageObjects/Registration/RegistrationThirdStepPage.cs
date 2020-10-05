using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainTrade.PageObjects.Registration
{
    class RegistrationThirdStepPage
    {
        IWebDriver _driver;
        public RegistrationThirdStepPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        By _webSite = By.CssSelector("#site");
        By _adress = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div[3]/div[1]/fieldset/div[2]/div/input");
        By _info = By.CssSelector("#comment");
        By _agree = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div[3]/div[3]");  //не факт что работает
        By _register = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div[4]/a");
        By _back = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div[2]/div[1]");

        public RegistrationThirdStepPage ClickTheButton(By locator)
        {
            _driver.FindElement(locator).Click();
            return this;
        }
    }
}
