using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainTrade.PageObjects.NewsPage
{
    public class NewsPage
    {
        IWebDriver _driver;
        public NewsPage(IWebDriver driver)
        {
            this._driver = driver;
        }

    }
}
