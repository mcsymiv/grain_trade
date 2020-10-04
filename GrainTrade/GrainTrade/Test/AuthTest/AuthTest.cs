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

namespace GrainTrade.Test.AuthTest
{
    [TestFixture]
    public class AuthTest
    {
        // IWebDriver chrome = new ChromeDriver(@"C:\Users\mcsymiv\Desktop\git\chromedriver_win32");
        IWebDriver firefox = new FirefoxDriver(@"C:\Users\mcsymiv\Desktop\git\geckodriver-v0.27.0-win64");
        HeaderUserNotAuth headerNotAuthPage;
        HeaderUserIsAuth headerIsAuthPage;
        AuthPage authPage;

        [SetUp]
        public void OpenGrainTradePage()
        {
            headerNotAuthPage = new HeaderUserNotAuth(firefox);
            headerIsAuthPage = new HeaderUserIsAuth(firefox);
            authPage = new AuthPage(firefox);

            firefox.Navigate().GoToUrl("https://dev.graintrade.com.ua");
            firefox.Manage().Window.Maximize();
            firefox.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        [OneTimeTearDown]
        public void CloseChromeWindow()
        {
            firefox.Quit();
        }
        [TestCase("vladhluzhin@gmail.com", "qazWSXedc", "Мій кабінет")]
        public void SuccessfulUserAuth(string email, string password, string myCabinet)
        {
            headerNotAuthPage.ClickAuthButton();
            authPage.UserSighIn(email, password);
            Assert.AreEqual(myCabinet, headerIsAuthPage.MyCabinetTextVisible());
        }
        [TestCase("", "qazWSXedc", "Это обязательное поле!")]
        [TestCase("vladhluzhin@gmail.com", "", "This field is required!")]
        [TestCase("test@gmail.com", "qazWSXedc", "Неверный e-mail")]
        public void EmptyFieldErrorOnAuthForm(string email, string password, string expectedErrorMessage)
        {
            headerNotAuthPage.ClickAuthButton();
            authPage.EmailUserEnter(email).PasswordUserEnter(password).SighInButtonClick();
            Assert.AreEqual(expectedErrorMessage, authPage.GetEmailErrorMessage());
            Assert.AreEqual(expectedErrorMessage, authPage.GetPasswordErrorMessage());
            Assert.AreEqual(expectedErrorMessage, authPage.GetEmailErrorMessage());
        }
    }
}
