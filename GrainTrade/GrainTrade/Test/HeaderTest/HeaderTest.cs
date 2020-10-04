using GrainTrade.PageObjects;
using GrainTrade.PageObjects.AuthPage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainTrade.Test
{
    [TestFixture]
    public class HeaderTest
    {
        IWebDriver chrome = new ChromeDriver(@"C:\Users\mcsymiv\Desktop\git\chromedriver_win32");
        HeaderUserNotAuth headerPage;
        AuthPage authPage;

        [SetUp]
        public void OpenGrainTradePage()
        {
            headerPage = new HeaderUserNotAuth(chrome);
            authPage = new AuthPage(chrome);

            chrome.Navigate().GoToUrl("https://dev.graintrade.com.ua");
            chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            // chrome.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            chrome.Manage().Window.Maximize();
        }
        [TearDown]
        public void CloseChromeWindow()
        {
            chrome.Quit();
        }
        [TestCase("Авторизація")]
        public void OpenAuthForm(string expectedFormTitle)
        {
            headerPage.ClickAuthButton();
            Assert.AreEqual(expectedFormTitle, authPage.GetAuthFormTitle());
        }
    }
}
