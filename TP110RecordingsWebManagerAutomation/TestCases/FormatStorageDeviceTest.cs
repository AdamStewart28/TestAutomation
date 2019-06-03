using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TP110RecordingsWebManagerAutomation.PageObjects;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace TP110RecordingsWebManagerAutomation.TestCases
{
    public class FormatStoragDeviceTest
    {
        [Test]
        public void Test()
        {
            // Opening the browser to the specified server
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://192.168.53.204:9443");

            // Entering the username and password and opening a domain
            var loginPage = new LogInPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.LogIntoApplication();

            // Selecting a Domain 
            var serverHomepage = new ServerHomepagePage();
            PageFactory.InitElements(driver, serverHomepage);
            WebDriverWait domainWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement domainButton = domainWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("[href*='#/domains/Audio']")));
            serverHomepage.ViewAllDomains();

            // Viewing all encoders
            var domainsPage = new DomainsPage();
            PageFactory.InitElements(driver, domainsPage);
            WebDriverWait AllDomainsWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement AllDomainsButton = AllDomainsWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//html[@class='ng-scope']/body[@id='top']/section[@id='float']/div[@class='content ng-scope']/div[@class='container ng-scope']/section[@class='status-bar']/div[@class='status-bar-body']/div[@class='surround'][2]/div[@class='overlay encoders']/span[@class='textbar']/p[1]/a[@class='baseLink ng-binding']")));
            domainsPage.ViewAllEncoders();

            // Selecing an encoder
            var encodersPage = new EncodersPage();
            PageFactory.InitElements(driver, encodersPage);
            WebDriverWait EncoderWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement EncoderButton = EncoderWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("[href*='#/domains/Audio/encoders/HDR700_Rec']")));
            encodersPage.SpecificEncoder();

            // Clicking on the Storage Devices link
            var storageDevicesLink = new EncoderPage();
            PageFactory.InitElements(driver, storageDevicesLink);
            WebDriverWait storageDevicesWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement StorageDevicesLinkButton = storageDevicesWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("[href*='#/domains/Audio/encoders/HDR700_Rec/storage/devices']")));
            storageDevicesLink.StorageDevicesLink();

            // Clicking into a storage device
            var storageDevices = new StorageDevicesPage();
            PageFactory.InitElements(driver, storageDevices);
            WebDriverWait storageDevicseWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement ClickStorageDevices = storageDevicesWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//html[@class='ng-scope']/body[@id='top']/section[@id='float']/div[@class='content ng-scope']/div[@class='container storage_page ng-scope']/div[@class='contentPage']/article/ul[@class='statusBoxes onecolumn']/li[@class='ng-scope'][3]/a")));
            storageDevices.ClickIntoStorageDevice();

            // Selecting 'Format'
            var formatMenu = new StorageDevicesPage();
            PageFactory.InitElements(driver, formatMenu);
            WebDriverWait formatMenuWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement ClickFormatMenu = formatMenuWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//html[@class='ng-scope']/body[@id='top']/section[@id='float']/div[@class='content ng-scope']/div[@class='container storage_page ng-scope']/div[@class='contentPage']/aside/ul/li[@class='ng-scope'][1]/a")));
            formatMenu.OpenFormatMenu();

            // Submitting Format
            var submitFormat = new StorageDevicesPage();
            PageFactory.InitElements(driver, submitFormat);
            WebDriverWait submitFormatWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement ClickSubmitFormat = submitFormatWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("submit")));
            submitFormat.FormatSubmit();

            // Refreshing the page
            //WebDriverWait refreshWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //IWebElement Refresh = refreshWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//html[@class='ng-scope']/body[@id='top']/section[@id='float']/div[@class='content ng-scope']/div[@class='container storage_page ng-scope']/div[@class='contentPage']/article[@class='ng-scope']/div[@class='info-block']/p[@class='info-block-content ng-binding']")));
            Thread.Sleep(20000);
            driver.Navigate().Refresh();

            // Exiting the test if completed
            WebDriverWait storageDeviceWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement StorageDeviceButton = storageDeviceWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//html[@class='ng-scope']/body[@id='top']/section[@id='float']/div[@class='content ng-scope']/div[@class='container storage_page ng-scope']/div[@class='contentPage']/article[@class='ng-scope']/div[@class='info-block']/p[@class='info-block-content ng-binding']")));
            driver.Quit();
        }
    }
}
