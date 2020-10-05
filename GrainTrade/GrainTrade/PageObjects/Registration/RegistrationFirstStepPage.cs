﻿using OpenQA.Selenium;
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

        By _email = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div/fieldset/div[1]/div/div/input");
        By _password = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div/fieldset/div[2]/div/div/input");
        By _repeatPassword = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div/fieldset/div[3]/div/div/input");
        By _enter = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[4]/a");
        By _back = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[2]/div[1]");


        public RegistrationFirstStepPage ClickTheButton(By locator)
        {
            _driver.FindElement(locator).Click();
            return this;
        }
    }
}
