using System;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace MSTest_Web_Test
{
    [TestClass]
    public class GoogleTest
    {
        private static IWebDriver driver;
        private StringBuilder verificationErrors;
        
        private bool acceptNextAlert = true;

        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            driver = new ChromeDriver();
        }

        [ClassCleanup]
        public static void CleanupClass()
        {
            try
            {
                //driver.Quit();// quit does not close the window
                driver.Close();
                driver.Dispose();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        [TestInitialize]
        public void InitializeTest()
        {
            verificationErrors = new StringBuilder();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestMethod]
        public void test568winSignIn()
        {
            
            driver.Navigate().GoToUrl("http://demo.568win.com/");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys("testnick");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("123456");
            driver.FindElement(By.Id("prevent-btn-sign-in")).Click();
            Console.WriteLine("----------Test for entering wrong password----------");
            Thread.Sleep(5000);
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys("testnick");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("1234asdf");
            driver.FindElement(By.Id("prevent-btn-sign-in")).Click();
            Console.WriteLine("----------Test entering correct password----------");

            driver.FindElement(By.XPath("//img[contains(@src,'https://img-1-10.cdn568.net/storage/customize/WebId-2274/Blue_SBO_Desktop_3/2243yy_logo_5f869bfc8ba7f_desktop.png?v=202201232224')]")).Click();
            Console.WriteLine("----------Test whether clicking on the title can return to the home page----------");

            driver.FindElement(By.XPath("//a[@id='home']/div[2]/i")).Click();
            Console.WriteLine("----------Test click on Sports field----------");

            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Deposit & Withdrawal'])[1]/following::span[3]")).Click();
            Console.WriteLine("----------Test click on Virtual Sports field----------");

            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Sports'])[1]/following::span[1]")).Click();
            Console.WriteLine("----------Test click on Live Casino field----------");

            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Virtual Sports'])[1]/following::span[1]")).Click();
            Console.WriteLine("----------Test click on Games field----------");

            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Live Casino'])[1]/following::span[1]")).Click();
            Console.WriteLine("----------Test click on CockFighting field----------");

            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Games'])[1]/following::span[1]")).Click();
            Console.WriteLine("----------Test click on Sports field----------");
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}