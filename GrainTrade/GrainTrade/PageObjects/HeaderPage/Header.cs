using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainTrade
{
    public class Header
    {
        By _mainLogo = By.XPath("/html/body/noindex/div/div[1]/div[1]/div[2]/div[3]");
        By _stockLink = By.XPath("/html/body/noindex/div/div[1]/div[1]/div[4]/div[1]/div[2]/ul/li[1]/a");
        By _newsLink = By.CssSelector("#yw0 > li:nth-child(2) > a");
        By _grainPriceLink = By.CssSelector("#yw0 > li:nth-child(3) > a");
        By _menuButton = By.XPath("/html/body/noindex/div/div[1]/div[1]/div[2]/div[3]");
    }
}
