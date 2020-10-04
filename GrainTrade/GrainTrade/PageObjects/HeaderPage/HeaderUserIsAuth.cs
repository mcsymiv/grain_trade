using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainTrade.PageObjects
{
    public class HeaderUserIsAuth : Header
    {
        IWebDriver _driver;
        public HeaderUserIsAuth(IWebDriver driver)
        {
            this._driver = driver;
        }
        By _myProposal = By.XPath("/html/body/noindex/div/div[1]/div[1]/div[4]/div[2]/div/div/a");
        By _myCabinet = By.CssSelector("#app > div.page-layout > div.header.transparent > div.container > div.cabinet-links > div > div.head-dropdown > div.button.transparent > a");

        public HeaderUserIsAuth ShowMyCabinetDropDown()
        {
            _driver.FindElement(_myCabinet).Click();
            Actions action = new Actions(_driver);
            action.MoveToElement(_driver.FindElement(_myCabinet)).Perform();
            return this;
        }
        public void MyProposalClick()
        {
            _driver.FindElement(_myProposal).Click();
        }
        public string MyCabinetTextVisible()
        {
            return _driver.FindElement(_myCabinet).Text;
        }
    }
}
