using GrainTrade.PageObjects;
using GrainTrade.PageObjects.AuthPage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainTrade.Test.AuthTest
{
    [TestFixture]
    public class AuthTest
    {
        // IWebDriver firefox = new FirefoxDriver(@"C:\Users\mcsymiv\Desktop\git\geckodriver-v0.27.0-win64");
        IWebDriver chrome;
        WebDriverWait wait;
        HeaderUserNotAuth headerNotAuthPage;
        HeaderUserIsAuth headerIsAuthPage;
        AuthPage authPage;
        ConfigTestFlow config;

        [SetUp]
        public void OpenGrainTradePage()
        {
            chrome = new ChromeDriver(@"C:\Users\mcsymiv\Desktop\git\chromedriver_win32");
            wait = new WebDriverWait(chrome, TimeSpan.FromSeconds(10));
            headerNotAuthPage = new HeaderUserNotAuth(chrome);
            headerIsAuthPage = new HeaderUserIsAuth(chrome);
            authPage = new AuthPage(chrome);
            config = new ConfigTestFlow(chrome);

            chrome.Navigate().GoToUrl("https://dev.graintrade.com.ua");
            config.Refresh();
            chrome.Manage().Window.Maximize();
            chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
        [TearDown]
        public void CloseChromeWindow()
        {
            chrome.Quit();
        }
        [TestCase("vladhluzhin@gmail.com", "qazWSXedc", "Мій кабінет")]
        public void SuccessfulUserAuth(string email, string password, string myCabinet)
        {
            headerNotAuthPage.ClickAuthButton();
            authPage.UserSighIn(email, password);
            Assert.AreEqual(myCabinet, headerIsAuthPage.MyCabinetTextVisible());
        }
        [TestCase("", "qazWSXedc", "Это обязательное поле!")]
        [TestCase("vladhluzhin@gmail.com", "", "Это обязательное поле!")]
        [TestCase("vladhluzhin@gmail.com", "12", "Это обязательное поле!")]
        public void InvalidAuthFieldInputErrors(string email, string password, string expectedErrorMessage)
        {
            headerNotAuthPage.ClickAuthButton();

            if (email.Length != 0)
            {
                authPage
                    .ClickOnEmailField()
                    .EmailUserEnter(email)
                    .SighInButtonClick();
                String passwordError = wait.Until(e => e.FindElement(authPage.PasswordError)).Text;
                Assert.AreEqual(expectedErrorMessage, passwordError);
            }
            else
            {
                authPage
                    .ClickOnPasswordField()
                    .PasswordUserEnter(password)
                    .SighInButtonClick();
                String emailErrorText = wait.Until(e => e.FindElement(authPage.EmailError)).Text;
                Assert.AreEqual(expectedErrorMessage, emailErrorText);
            }
        }
    }
}
