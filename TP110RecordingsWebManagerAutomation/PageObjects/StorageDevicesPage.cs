using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TP110RecordingsWebManagerAutomation.PageObjects
{
    public class StorageDevicesPage
    {
        private readonly IWebDriver driver;

        // Clicking the 'Storage Settings' menu
        [FindsBy(How = How.CssSelector, Using = "[href*='#/domains/Audio/encoders/HDR700_Rec/storage/devices/settings']")]
        public IWebElement StorageSettingsLink { get; set; }

        public void StorageSettings()
        {
            StorageSettingsLink.Click();
        }

        // Clicking to disable/enable one of the storage devices
        [FindsBy(How = How.XPath, Using = "//html[@class='ng-scope']/body[@id='top']/section[@id='float']/div[@class='content ng-scope']/div[@class='container ng-scope']/form[@id='form']/div[@class='ng-scope']/div[@class='ng-scope']/p[@class='radio ng-scope'][2]/label[@class='ng-binding']")]
        public IWebElement DisableEnable { get; set; }

        public void DisableEnableStorageDevice()
        {
            DisableEnable.Click();
        }

        // Submit button
        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement SubmitButton { get; set; }

        public void Submit()
        {
            SubmitButton.Click();
        }

        // Selecting one of the storage devices
        [FindsBy(How = How.XPath, Using = "//html[@class='ng-scope']/body[@id='top']/section[@id='float']/div[@class='content ng-scope']/div[@class='container storage_page ng-scope']/div[@class='contentPage']/article/ul[@class='statusBoxes onecolumn']/li[@class='ng-scope'][3]/a")]
        public IWebElement EnterStorageDeivce { get; set; }

        public void ClickIntoStorageDevice()
        {
            EnterStorageDeivce.Click();
        }

        // Format menu for an encoder
        [FindsBy(How = How.XPath, Using = "//html[@class='ng-scope']/body[@id='top']/section[@id='float']/div[@class='content ng-scope']/div[@class='container storage_page ng-scope']/div[@class='contentPage']/aside/ul/li[@class='ng-scope'][1]/a")]
        public IWebElement EnterFormatMenu { get; set; }

        public void OpenFormatMenu()
        {
            EnterFormatMenu.Click();
        }

        // Confirm Format Device
        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement SubmitFormat { get; set; }

        public void FormatSubmit()
        {
            SubmitFormat.Click();
        }
    }
}
