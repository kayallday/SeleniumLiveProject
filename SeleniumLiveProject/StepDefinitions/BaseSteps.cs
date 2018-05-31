using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System.Configuration;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.PhantomJS;

namespace SeleniumLiveProject.StepDefinitions
{
    [TestFixture]
    class BaseSteps : Steps
    {
        protected IWebDriver Driver;
        public static string BrowserName;
        public static string VendorDirectory;
        public static string ApplicationBaseUrl;

        protected void LoadConfigValues()
        {
            BrowserName = GetConfigValue("BrowserName");
            ApplicationBaseUrl = GetConfigValue("ApplicationBaseUrl");
            VendorDirectory = GetConfigValue("VendorDirectory");
        }

        private string GetConfigValue(string key)
        {
            return (string)TestContext.CurrentContext.Test.Properties.Get(key) ?? ConfigurationManager.AppSettings[key];
        }

        [SetUp]
        protected void CheckBrowser()
        {
            switch (BrowserName.ToLower())
            {
                case "firefox":
                    Driver = new FirefoxDriver();
                    Driver.Manage().Window.Maximize();
                    Driver.Manage().Timeouts().PageLoad = System.TimeSpan.FromSeconds(45);
                    ScenarioContext.Current["Driver"] = Driver;
                    break;
                case "chrome":
                    Driver = new ChromeDriver();
                    Driver.Manage().Window.Maximize();
                    Driver.Manage().Timeouts().PageLoad = System.TimeSpan.FromSeconds(60);
                    ScenarioContext.Current["Driver"] = Driver;
                    break;
                case "ie":
                    Driver = new InternetExplorerDriver();
                    Driver.Manage().Window.Maximize();
                    Driver.Manage().Timeouts().PageLoad = System.TimeSpan.FromSeconds(45);
                    ScenarioContext.Current["Driver"] = Driver;
                    break;
                case "phantomjs":
                    Driver = new PhantomJSDriver();
                    Driver.Manage().Window.Maximize();
                    Driver.Manage().Timeouts().PageLoad = System.TimeSpan.FromSeconds(45);
                    ScenarioContext.Current["Driver"] = Driver;
                    break;
                case "headlesschrome":
                    ChromeOptions option = new ChromeOptions();
                    option.AddArgument("--headless");
                    Driver = new ChromeDriver(option);
                    Driver.Manage().Timeouts().PageLoad = System.TimeSpan.FromSeconds(45);
                    ScenarioContext.Current["Driver"] = Driver;
                    break;
            }
        }
        protected void NavigateToBaseURL()
        {
            Driver.Navigate().GoToUrl(ApplicationBaseUrl);
        }
    }
}
