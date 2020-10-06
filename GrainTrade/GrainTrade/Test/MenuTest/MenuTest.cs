using GrainTrade.PageObjects.LeftMenuPage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainTrade.Test.MenuTest
{
    [TestFixture]
    public class MenuTest
    {
        IWebDriver chrome;
        WebDriverWait wait;
        LeftMenuPage menuPage;
        ConfigTestFlow config;


        [SetUp]
        public void InitTest()
        {
            chrome = new ChromeDriver(@"C:\Users\mcsymiv\Desktop\git\chromedriver_win32");
            wait = new WebDriverWait(chrome, TimeSpan.FromSeconds(10));
            menuPage = new LeftMenuPage(chrome);
            config = new ConfigTestFlow(chrome);

            chrome.Navigate().GoToUrl("https://dev.graintrade.com.ua");
            config.Refresh();
            chrome.Manage().Window.Maximize();
            chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        [TearDown]
        public void CloseChromeWindow()
        {
            chrome.Quit();
        }
        [TestCase(1, "Біржа зерна Online")]
        [TestCase(2, "Новини")]
        [TestCase(3, "Ціни на зерно")]
        [TestCase(4, "Статистика")]
        [TestCase(5, "Карта")]
        [TestCase(6, "Трейдери")]
        [TestCase(7, "Виробники")]
        [TestCase(8, "Елеватори")]
        public void LeftMainMenuLinksCheck(int link, string expectedTitle)
        {
            String actualTitle = string.Empty;
            menuPage.MenuButtonOpen();
            switch (link)
            {
                case 1:
                    actualTitle = menuPage
                        .MenuLinkClick(menuPage.Exchange)
                        .GetElementTitle(menuPage.ExchangeTitle);
                    break;
                case 2:
                    actualTitle = menuPage
                        .MenuLinkClick(menuPage.News)
                        .GetElementTitle(menuPage.NewsTitle);
                    break;
                case 3:
                    actualTitle = menuPage
                        .MenuLinkClick(menuPage.Prices)
                        .GetElementTitle(menuPage.PriceTitle);
                    break;
                case 4:
                    actualTitle = menuPage
                        .MenuLinkClick(menuPage.Stats)
                        .GetElementTitle(menuPage.StatsTitle);
                    break;
                case 5:
                    actualTitle = menuPage
                        .MenuLinkClick(menuPage.Map)
                        .GetElementTitle(menuPage.MapTitle);
                    break;
                case 6:
                    actualTitle = menuPage
                        .MenuLinkClick(menuPage.Traiders)
                        .GetElementTitle(menuPage.TraidersPageTitle);
                    break;
                case 7:
                    actualTitle = menuPage
                        .MenuLinkClick(menuPage.Manufacturers)
                        .GetElementTitle(menuPage.ManufacturersPageTitle);
                    break;
                case 8:
                    actualTitle = menuPage
                        .MenuLinkClick(menuPage.Elevators)
                        .GetElementTitle(menuPage.ElevatorsPageTitle);
                    break;
            }
            Assert.AreEqual(expectedTitle, actualTitle);
        }
    }
}
