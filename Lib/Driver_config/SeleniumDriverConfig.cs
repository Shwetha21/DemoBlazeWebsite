using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace DemoBlazeWebsite.Lib.Driver_config
{
    public class SeleniumDriverConfig
    {
        public IWebDriver Driver { get; set; }
        public SeleniumDriverConfig(string drivername, int pageLoadInSecs, int implicitWaitInsecs)
        {
            DriverSetUp(drivername, pageLoadInSecs, implicitWaitInsecs);
        }

        private void DriverSetUp(string drivername, int pageLoadInSecs, int implicitWaitInsecs)
        {
            if (drivername.ToLower() == "chrome")
            {
                SetChromeDriver();
            }
            else if (drivername.ToLower() == "firefox")
            {
                SetFirefoxDriver();
            }
            else
            {
                throw new Exception("use 'chrome' or 'firefox'");
            }

            SetDriverConfiguration(pageLoadInSecs, implicitWaitInsecs);
        }

        private void SetDriverConfiguration(int pageLoadInSecs, int implicitWaitInsecs)
        {
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInSecs);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInsecs);
        }

        private void SetFirefoxDriver()
        {
            Driver = new FirefoxDriver();
        }

        private void SetChromeDriver()
        {
            Driver = new ChromeDriver();
        }
    }
}
