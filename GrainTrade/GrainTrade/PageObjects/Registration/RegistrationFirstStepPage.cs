using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainTrade.PageObjects.Registration
{
    class RegistrationFirstStepPage
    {
        IWebDriver _driver;
        public RegistrationFirstStepPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        By _email = By.CssSelector("#e-mail");

        By _password = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div/fieldset/div[2]/div/div/input");
        By _copyPassword = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div/fieldset/div[3]/div/div/input");
        By _enter = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[4]/a");
        By _back = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[2]/div[1]");

        public RegistrationFirstStepPage ClickTheButton(char back, char enter)
        {
            if (back == '+')
            {
                _driver.FindElement(_back).Click();
            }
            if (enter == '+')
            {
                _driver.FindElement(_enter).Click();
            }
            return this;
        }
        public RegistrationFirstStepPage EnterInput(string what, string where)
        {
            By locator = _enter;

            if (where == "email" || where == "e-mail")
            {
                locator = _email;
            }
            if (where == "password" || where == "pass")
            {
                locator = _password;
            }
            if (where == "copyPassword" || where == "copyPass")
            {
                locator = _copyPassword;
            }

            _driver.FindElement(locator).SendKeys(what);
            return this;
        }
    }
}
