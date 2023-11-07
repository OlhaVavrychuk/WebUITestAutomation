﻿using OpenQA.Selenium;
using WebUITestAutomation.Core;

namespace WebUITestAutomation.Business.PageObjects
{
    public class JobListingPage : BasePage
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly By _jobDetailsBy = By.CssSelector("article.vacancy-details-23");

        public JobListingPage(IWebDriver driver) : base(driver)
        {
        }

        public string GetJobDetails()
        {
            return driver.FindElementWithWait(_jobDetailsBy).Text;
        }
    }
}
