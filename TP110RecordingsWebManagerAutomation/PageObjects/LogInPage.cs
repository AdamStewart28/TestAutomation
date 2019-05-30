﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace TP110RecordingsWebManagerAutomation.PageObjects
{
    public class LogInPage
    {        
        private readonly IWebDriver driver;

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement Submit { get; set; }

        public void LogIntoApplication()
        {
            // (*CHANGE CREDENTIALS ACCORDINGLY*)
            Username.SendKeys("AdamS");
            Password.SendKeys("password1");
            Submit.Click();
        }
    }
}
