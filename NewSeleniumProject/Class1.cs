﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.PhantomJS;
using System;

namespace Partsunlimited.UITests
{ 

    [TestClass]
    public class ChucksClass1
    {
        private string baseURL = "https://dev-platform.authenticateis.com/Account/Logon";
        private RemoteWebDriver driver;
        private string browser;
        public TestContext TestContext { get; set; }
        public string BaseURL { get => baseURL; set => baseURL = value; }

        [TestMethod]
        [TestCategory("Selenium")]
        [Priority(1)]
        [Owner("FireFox")]

        public void TireSearch_Any()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl(this.baseURL);
            driver.FindElementById("search - box").Clear();
            driver.FindElementById("search - box").SendKeys("tire");
            //do other Selenium things here!
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            driver.Quit();
        }

        [TestInitialize()]
        public void MyTestInitialize()
        {
        }
    }
}