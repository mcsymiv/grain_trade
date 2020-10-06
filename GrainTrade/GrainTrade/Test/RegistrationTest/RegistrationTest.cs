using GrainTrade.PageObjects;
using GrainTrade.PageObjects.AuthPage;
using GrainTrade.PageObjects.Registration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainTrade.Test.RegistrationTest
{
    [TestFixture]
    public class RegistrationTest
    {
        IWebDriver chrome;
        // IWebDriver firefox = new FirefoxDriver(@"C:\Users\mcsymiv\Desktop\git\geckodriver-v0.27.0-win64");
        HeaderUserNotAuth headerNotAuthPage;
        RegistrationFirstStepPage reg1;
        RegistrationSecondStepPage reg2;
        RegistrationThirdStepPage reg3;
        AuthPage authPage;
        ConfigTestFlow config;


        [SetUp]
        public void OpenGrainTradePage()
        {
            chrome = new ChromeDriver(@"C:\Users\User\Desktop\GrainTrade\graine_trade autoTests\GrainTrade"); //@"C:\Users\mcsymiv\Desktop\git\chromedriver_win32
            headerNotAuthPage = new HeaderUserNotAuth(chrome);
            config = new ConfigTestFlow(chrome);
            reg1 = new RegistrationFirstStepPage(chrome);
            reg2 = new RegistrationSecondStepPage(chrome);
            reg3 = new RegistrationThirdStepPage(chrome);
            authPage = new AuthPage(chrome);
            chrome.Navigate().GoToUrl("https://dev.graintrade.com.ua");
            config.Refresh();
            chrome.Manage().Window.Maximize();
            chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            headerNotAuthPage.ClickAuthButton();
            authPage.ClickOnRegister();
        }


        [TearDown]
        public void CloseChromeWindow()
        {
            chrome.Quit();
        }


        [TestCase("test1@gmail.com", "qazWSXedc", "qazWSXedc", '-', '+', "українська", "test", "12345678", "Трейдер", "Експортер", "PIB", "PIB", "0981060000", "PIB", '-', '+', "https://deveducation.com/", "Київ, Україна", "Extra info", '+', '+', '-')]
        [TestCase("test2@gmail.com", "qazWSXedc", "qazWSXedc", '-', '+', "русский", "test2", "12345678", "Виробник", "Фермер", "P I B", "P I B", "0981060000", "P I B", '-', '+', "https://deveducation.com/", "Київ, Україна", "Extra info", '+', '+', '-')]
        [TestCase("test3@gmail.com", "qazWSXedc", "qazWSXedc", '-', '+', "українська", "test3", "87654321", "Елеватор", "Державний", "PIB", "PIB", "0981060000", "PIB", '-', '+', "https://deveducation.com/", "Київ, Україна", "Extra info", '+', '+', '-')]
        [TestCase("test4@gmail.com", "qazWSXedc", "qazWSXedc", '-', '+', "русский", "test4", "12345678", "Трейдер", "Посередник", "P I B", "P I B", "0981060000", "P I B", '-', '+', "https://deveducation.com/", "Київ, Україна", "Extra info", '+', '+', '-')]
        public void RegistrationFull(string email, string password, string copyPassword, char back1, char enter1, string language, string nameOfCompany,
                                     string USREOUCode, string userType, string userTypeExtra, string directorOfTheEnterprise, string theOwnerOfTheEnterprise,
                                     string contactPhone, string contactPerson, char back2, char enter2, string webSite, string adress, string info, char agree,
                                     char register, char back3)
        {

            reg1.EnterInput(password, "pass");
            reg1.EnterInput(copyPassword, "copyPass");
            reg1.EnterInput(email, "email");
            reg1.ClickTheButton('-', '+');

            if (enter1 == '+')
            {
                reg2.ChoseFromList("українська");
                reg2.ChoseFromList(userType);
                reg2.ChoseFromList(userTypeExtra);
                reg2.EnterInput(nameOfCompany, "NOC");
                reg2.EnterInput(USREOUCode, "USREOUCode");
                reg2.EnterInput(directorOfTheEnterprise, "directorOfTheEnterprise");
                reg2.EnterInput(theOwnerOfTheEnterprise, "theOwnerOfTheEnterprise");
                reg2.EnterInput(contactPhone, "contactPhone");
                reg2.EnterInput(contactPerson, "contactPerson");
                reg2.ClickTheButton('-', '+');

                if (enter2 == '+')
                {
                    reg3.EnterInput(webSite, "webSite");
                    reg3.EnterInput(adress, "adress");
                    reg3.EnterInput(info, "info");
                    reg3.ClickTheButton(agree, register, back3);
                }
            }
        }
    }
}
