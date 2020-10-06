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

namespace GrainTrade.Test
{
    [TestFixture]
    public class HeaderTest
    {
        // IWebDriver firefox = new FirefoxDriver(@"C:\Users\mcsymiv\Desktop\git\geckodriver-v0.27.0-win64");
        IWebDriver chrome;
        HeaderUserNotAuth headerPage;
        AuthPage authPage;
        ConfigTestFlow config;

        [SetUp]
        public void OpenGrainTradePage()
        {
            chrome = new ChromeDriver(@"C:\Users\mcsymiv\Desktop\git\chromedriver_win32");
            headerPage = new HeaderUserNotAuth(chrome);
            authPage = new AuthPage(chrome);
            config = new ConfigTestFlow(chrome);

            chrome.Navigate().GoToUrl("https://dev.graintrade.com.ua");
            config.Refresh();
            chrome.Manage().Window.Maximize();
            chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
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
            String authTitle = authPage.GetAuthFormTitle();
            Assert.AreEqual(expectedFormTitle, authTitle);
        }
        [TestCase(1, "Біржа зерна Online")]
        [TestCase(2, "Новини")]
        [TestCase(3, "Ціни на зерно")]
        public void HeaderLinksCheck(int link, string expectedTitle)
        {
            string actualTitle = string.Empty;
            switch (link)
            {
                case 1:
                    actualTitle = headerPage
                        .ClickOnHeaderLinkAction(headerPage.ExchangeLink)
                        .GetPageTitle(headerPage.ExchangePageTitle);
                    break;
                case 2:
                    actualTitle = headerPage
                        .ClickOnHeaderLinkAction(headerPage.NewsLink)
                        .GetPageTitle(headerPage.NewsPageTitle);
                    break;
                case 3:
                    actualTitle = headerPage
                        .ClickOnHeaderLinkAction(headerPage.PriceLink)
                        .GetPageTitle(headerPage.PricePageTitle);
                    break;
            }
            Assert.AreEqual(expectedTitle, actualTitle);
        }
    }
}
