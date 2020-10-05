using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GrainTrade.PageObjects.AuthPage
{
    public class AuthPage
    {
        IWebDriver _driver;
        public AuthPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        By _email = By.Id("login");
        By _password = By.Id("password");
        By _sighInButton = By.XPath("/html/body/noindex/div/div[5]/div[3]/div[2]/div[1]/div[1]/fieldset/div[3]/div");
        By _registrationLink = By.CssSelector("html body.no-scroll noindex div#app.page-wrap div.modal-window-wrap.auth-modal div.modal-window-content div.modal-window-body.ps-container.ps-theme-default div.login-form-wrap div.links-block div.registration-block a.registration");
        By _authFormTitle = By.XPath("/html/body/noindex/div/div[5]/div[3]/div[1]/div");

        public By EmailError = By.XPath("/html/body/noindex/div/div[5]/div[3]/div[2]/div[1]/div[1]/fieldset/div[1]/div[2]/span");        
        public By PasswordError = By.XPath("/html/body/noindex/div/div[5]/div[3]/div[2]/div[1]/div[1]/fieldset/div[2]/div[2]/span");

        public AuthPage UserSighIn(string email, string password)
        {
            _driver.FindElement(_email).SendKeys(email);
            _driver.FindElement(_password).SendKeys(password);
            _driver.FindElement(_sighInButton).Click();
            return this;
        }
        public AuthPage EmailUserEnter(string email)
        {
            _driver.FindElement(_email).SendKeys(email);
            return this;
        }
        public AuthPage PasswordUserEnter(string password)
        {
            _driver.FindElement(_password).SendKeys(password);
            return this;
        }
        public AuthPage SighInButtonClick()
        {
            _driver.FindElement(_sighInButton).Click();
            return this;
        }
        public string GetAuthFormTitle()
        {
            return _driver.FindElement(_authFormTitle).Text;
        }
        public AuthPage ClickOnEmailField()
        {
            _driver.FindElement(_email).Click();
            return this;
        }
        public AuthPage ClickOnPasswordField()
        {
            _driver.FindElement(_password).Click();
            return this;
        }
    }
}
