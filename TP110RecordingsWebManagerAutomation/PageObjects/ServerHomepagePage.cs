using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace TP110RecordingsWebManagerAutomation.PageObjects
{
    public class ServerHomepagePage
    {
        private readonly IWebDriver driver;

        // (*CHANGE DOMAIN ACCORDINGLY*)
        [FindsBy(How = How.CssSelector, Using = "[href*='#/domains/Audio']")]
        public IWebElement Domains { get; set; }

        public void ViewAllDomains()
        {
            Domains.Click();
        }

    }
}
