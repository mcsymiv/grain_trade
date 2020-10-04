using GrainTrade.PageObjects;
using GrainTrade.PageObjects.AuthPage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
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
        // IWebDriver chrome = new ChromeDriver(@"C:\Users\mcsymiv\Desktop\git\chromedriver_win32");
        IWebDriver firefox = new FirefoxDriver(@"C:\Users\mcsymiv\Desktop\git\geckodriver-v0.27.0-win64");
        HeaderUserNotAuth headerPage;
        AuthPage authPage;

        [SetUp]
        public void OpenGrainTradePage()
        {
            headerPage = new HeaderUserNotAuth(firefox);
            authPage = new AuthPage(firefox);

            firefox.Navigate().GoToUrl("https://dev.graintrade.com.ua");
            firefox.Manage().Window.Maximize();
            firefox.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        [TearDown]
        public void CloseChromeWindow()
        {
            firefox.Quit();
        }
        [TestCase("Авторизація")]
        public void OpenAuthForm(string expectedFormTitle)
        {
            headerPage.ClickAuthButton();
            Assert.AreEqual(expectedFormTitle, authPage.GetAuthFormTitle());
        }
    }
}
