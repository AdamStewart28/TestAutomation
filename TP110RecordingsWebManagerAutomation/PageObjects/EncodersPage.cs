using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TP110RecordingsWebManagerAutomation.PageObjects
{
    public class EncodersPage
    {        
        private readonly IWebDriver driver;

        // (*CHANGE ENCODER ACCORDINGLY*)
        [FindsBy(How = How.CssSelector, Using = "[href*='#/domains/Audio/encoders/HDR700_Rec']")]
        public IWebElement UserEncoder { get; set; }

        public void SpecificEncoder()
        {
            UserEncoder.Click();
        }
    }
}
