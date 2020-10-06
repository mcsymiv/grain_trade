using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainTrade.PageObjects.Registration
{
    public class RegistrationThirdStepPage
    {
        IWebDriver _driver;
        public RegistrationThirdStepPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        By _webSite = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div[3]/div[1]/fieldset/div[1]/div/div/input");
        By _adress = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div[3]/div[1]/fieldset/div[2]/div/input");
        By _info = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div[3]/div[1]/fieldset/div[3]/div/textarea");
        By _agree = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div[3]/div[3]/label/span");
        By _register = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div[4]/a");
        By _back3 = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div[2]/div[1]");

        public RegistrationThirdStepPage ClickTheButton(By locator)
        {
            _driver.FindElement(locator).Click();
            return this;
        }
        public RegistrationThirdStepPage EnterInput(string what, string where)
        {
            By locator = _register;

            if (where == "webSite" || where == "web-site")
            {
                locator = _webSite;
            }
            if (where == "adress" || where == "Adress")
            {
                locator = _adress;
            }
            if (where == "info" || where == "Info")
            {
                locator = _info;
            }
            _driver.FindElement(locator).SendKeys(what);
            return this;
        }
        public RegistrationThirdStepPage ClickTheButton(char agree, char register, char back3)
        {
            if (agree == '+')
            {
                _driver.FindElement(_agree).Click();
            }
            if (register == '+')
            {
                _driver.FindElement(_register).Click();
            }
            if (back3 == '+')
            {
                _driver.FindElement(_back3).Click();
            }
            return this;
        }
    }
}
