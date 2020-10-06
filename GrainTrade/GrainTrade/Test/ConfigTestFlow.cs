using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainTrade.Test
{
    public class ConfigTestFlow
    {
        IWebDriver _driver;
        public ConfigTestFlow(IWebDriver driver)
        {
            this._driver = driver;
        }
        public void PassChromeSecurityWindow()
        {
            _driver.FindElement(By.XPath("/html/body/div/div[2]/button[3]")).Click();
            _driver.FindElement(By.CssSelector("#proceed-link")).Click();
        }
        public void Refresh()
        {
            _driver.Navigate().Refresh();
        }
    }
}
