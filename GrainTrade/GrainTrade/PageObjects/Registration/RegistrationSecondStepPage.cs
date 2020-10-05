using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainTrade.PageObjects.Registration
{
    class RegistrationSecondStepPage
    {
        IWebDriver _driver;
        public RegistrationSecondStepPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        By _language = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div/fieldset/div[1]/div/div/span/span[1]/span/span[1]");
        By _nameOfCompany = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div/fieldset/div[3]/div/div/input");
        By _USREOUCode = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div/fieldset/div[5]/div/div/input");
        By _UserType = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div/fieldset/div[7]/div/div/span/span[1]/span/span[1]");
        By _UserTypeExtra = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div/fieldset/div[9]/div/div/span/span[1]/span/span[1]");
        By _DirectorOfTheEnterprise = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div/fieldset/div[2]/div/div/input");
        By _TheOwnerOfTheEnterprise = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div/fieldset/div[4]/div/div/input");
        By _ContactPhone = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div/fieldset/div[6]/div/div/input");
        By _contactPerson = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div/fieldset/div[8]/div/div/input");
        By _enter = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[4]/a");
        By _back = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[2]/div[1]");

        public RegistrationSecondStepPage ClickTheButton(By locator)
        {
            _driver.FindElement(locator).Click();
            return this;
        }
    }
}
