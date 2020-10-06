using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainTrade.PageObjects.Registration
{
    public class RegistrationSecondStepPage
    {
        IWebDriver _driver;
        public RegistrationSecondStepPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        By _language = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div/fieldset/div[1]/div/div/span/span[1]/span/span[1]");
        By _ukr = By.XPath("/html/body/span/span/span[2]/ul/li[1]");
        By _ru = By.XPath("/html/body/span/span/span[2]/ul/li[2]");
        By _eng = By.XPath("/html/body/span/span/span[2]/ul/li[3]");
        By _nameOfCompany = By.CssSelector("#name");
        By _USREOUCode = By.CssSelector("#ZKPO");
        By _UserType = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div/fieldset/div[7]/div/div/span/span[1]/span/span[1]");
        By _UserTypeExtra = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[3]/div/fieldset/div[9]/div/div/span/span[1]/span/span[1]");

        By _DirectorOfTheEnterprise = By.CssSelector("#director");
        By _TheOwnerOfTheEnterprise = By.CssSelector("#owner");
        By _ContactPhone = By.CssSelector("#phone");
        By _contactPerson = By.CssSelector("#contact");
        By _enter = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[4]/a");
        public By _back = By.XPath("/html/body/noindex/div/div[2]/div[1]/div/div/div/div[2]/div[1]");

        By _treider = By.XPath("/html/body/span/span/span[2]/ul/li[1]");
        By _E_exporter = By.XPath("/html/body/span/span/span[2]/ul/li[1]");
        By _E_FirstPoserednuk = By.XPath("/html/body/span/span/span[2]/ul/li[2]");
        By _E_Poserednuk = By.XPath("/html/body/span/span/span[2]/ul/li[3]");

        By _virobnyk = By.XPath("/html/body/span/span/span[2]/ul/li[2]");
        By _E_AgroHolding = By.XPath("/html/body/span/span/span[2]/ul/li[1]");
        By _E_AgroFirma = By.XPath("/html/body/span/span/span[2]/ul/li[2]");
        By _E_Fermer = By.XPath("/html/body/span/span/span[2]/ul/li[3]");

        By _elevator = By.XPath("/html/body/span/span/span[2]/ul/li[3]");
        By _E_Commercial = By.XPath("/html/body/span/span/span[2]/ul/li[1]");
        By _E_Fermerskiy = By.XPath("/html/body/span/span/span[2]/ul/li[2]");
        By _E_Zmishanui = By.XPath("/html/body/span/span/span[2]/ul/li[3]");
        By _E_Dershavnui = By.XPath("/html/body/span/span/span[2]/ul/li[4]");

        By _expeditor = By.XPath("/html/body/span/span/span[2]/ul/li[4]");
        By _E_Auto = By.XPath("/html/body/span/span/span[2]/ul/li[1]");
        By _E_Zaliznucya = By.XPath("/html/body/span/span/span[2]/ul/li[2]");

        By _port = By.XPath("/html/body/span/span/span[2]/ul/li[5]");

        By _terminal = By.XPath("/html/body/span/span/span[2]/ul/li[6]");
        By _E_Zernovui = By.XPath("/html/body/span/span/span[2]/ul/li[1]");
        By _E_Olienaluvnui = By.XPath("/html/body/span/span/span[2]/ul/li[2]");

        By _holding = By.XPath("/html/body/span/span/span[2]/ul/li[7]");

        By _pererobnyk = By.XPath("/html/body/span/span/span[2]/ul/li[8]");
        By _E_VsiPeperob = By.XPath("/html/body/span/span/span[2]/ul/li[1]");
        By _E_MasloZavod = By.XPath("/html/body/span/span/span[2]/ul/li[2]");
        By _E_Mlun = By.XPath("/html/body/span/span/span[2]/ul/li[3]");
        By _E_CombikormZavod = By.XPath("/html/body/span/span/span[2]/ul/li[4]");

        public RegistrationSecondStepPage ClickTheButton(char back2, char enter2)
        {
            if (back2 == '+')
            {
                _driver.FindElement(_back).Click();
            }
            if (enter2 == '+')
            {
                _driver.FindElement(_enter).Click();
            }
            return this;
        }
        public RegistrationSecondStepPage EnterInput(string what, string where)
        {
            By locator = _enter;

            if (where == "nameOfCompany" || where == "NOC")
            {
                locator = _nameOfCompany;
            }
            if (where == "USREOUCode" || where == "code")
            {
                locator = _USREOUCode;
            }
            if (where == "directorOfTheEnterprise" || where == "DOTE")
            {
                locator = _DirectorOfTheEnterprise;
            }
            if (where == "theOwnerOfTheEnterprise" || where == "TOTE")
            {
                locator = _TheOwnerOfTheEnterprise;
            }
            if (where == "contactPhone" || where == "CPh")
            {
                locator = _ContactPhone;
            }
            if (where == "contactPerson" || where == "CPer")
            {
                locator = _contactPerson;
            }
            if (where == "contactPerson" || where == "CPer")
            {
                locator = _contactPerson;
            }
            _driver.FindElement(locator).SendKeys(what);
            //_driver.FindElement(_email).SendKeys("test");
            return this;
        }
        public void ChoseFromList(string what)
        {
            string _what = " ";
            By _where = By.XPath("");
            By _which = By.XPath("");

            if (what == "українська")
            {
                _what = "language";
                _which = _ukr;
            }
            if (what == "русский")
            {
                _what = "language";
                _which = _ru;
            }
            if (what == "english")
            {
                _what = "language";
                _which = _eng;
            }
            if (what == "трейдер" || what == "Трейдер")
            {
                _what = "userType";
                _which = _treider;
            }
            if (what == "виробник" || what == "Виробник")
            {
                _what = "userType";
                _which = _virobnyk;
            }
            if (what == "елеватор" || what == "Елеватор")
            {
                _what = "userType";
                _which = _elevator;
            }
            if (what == "експедитор" || what == "Експедитор")
            {
                _what = "userType";
                _which = _expeditor;
            }
            if (what == "порт" || what == "Порт")
            {
                _what = "userType";
                _which = _port;
            }
            if (what == "термінал" || what == "Термінал")
            {
                _what = "userType";
                _which = _terminal;
            }
            if (what == "холдинг" || what == "Холдинг")
            {
                _what = "userType";
                _which = _holding;
            }

            if (what == "Експортер" || what == "експортер")
            {
                _what = "userTypeExtra";
                _which = _E_exporter;
            }
            if (what == "Перший посередник" || what == "перший посередник")
            {
                _what = "userTypeExtra";
                _which = _E_FirstPoserednuk;
            }
            if (what == "Посередник" || what == "посередник")
            {
                _what = "userTypeExtra";
                _which = _E_Poserednuk;
            }
            if (what == "Агрохолдинг" || what == "агрохолдинг")
            {
                _what = "userTypeExtra";
                _which = _E_AgroHolding;
            }
            if (what == "Агрофірма" || what == "агрофірма")
            {
                _what = "userTypeExtra";
                _which = _E_AgroFirma;
            }
            if (what == "Фермер" || what == "фермер")
            {
                _what = "userTypeExtra";
                _which = _E_Fermer;
            }
            if (what == "Комерційний" || what == "комерційний")
            {
                _what = "userTypeExtra";
                _which = _E_Commercial;
            }
            if (what == "Фермерський" || what == "фермерський")
            {
                _what = "userTypeExtra";
                _which = _E_Fermerskiy;
            }
            if (what == "Змішаний" || what == "змішаний")
            {
                _what = "userTypeExtra";
                _which = _E_Zmishanui;
            }
            if (what == "Державний" || what == "державний")
            {
                _what = "userTypeExtra";
                _which = _E_Dershavnui;
            }
            switch (_what)
            {
                case "language":
                    _where = _language;
                    break;
                case "userType":
                    _where = _UserType;
                    break;
                case "userTypeExtra":
                    _where = _UserTypeExtra;
                    break;
            }
            _driver.FindElement(_where).Click();
            _driver.FindElement(_which).Click();
        }
    }
}
