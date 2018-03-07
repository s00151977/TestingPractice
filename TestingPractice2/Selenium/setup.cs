using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace Selenium
{
    [TestClass]
    public class setup
    {
        [TestMethod]
        public void setupDllTest()
        {
            TestMethod("male", 22);
            TestMethod("female", 70);
        }

        public void TestMethod(string gender, int age)
        {

            IWebDriver driver = new ChromeDriver();
            try
            {

                
                string url = "http://localhost:9156/WebForm1.aspx";
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("TextGender")).SendKeys(gender);
                driver.FindElement(By.Id("TextAge")).SendKeys(age.ToString());
                driver.FindElement(By.Id("Button1")).Click();



                WebDriverWait wait;
                wait = new WebDriverWait(driver, new TimeSpan(0, 0, 2));
                wait.Until(wt => wt.FindElement(By.Id("editUserModalContent")));

                driver.Close();
                driver.Dispose();


            }
            catch (Exception)
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();

                Random rnd = new Random();
                int x = rnd.Next(1, 100000);
                screenshot.SaveAsFile("H:/Test" + x + ".png", ScreenshotImageFormat.Png);

                driver.Quit();
            }
        }


    }
}
