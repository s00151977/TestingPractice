using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Selenium
{
    [TestClass]
    public class setup
    {
        [TestMethod]
        public void setupDllTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:58911/WebForm1.aspx");
        }
    }
}
