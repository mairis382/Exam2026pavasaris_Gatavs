using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ClassLibrary1.Tests
{
    [TestClass]
    public class test
    {
        [TestMethod]
        public void Test1_field()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ebay.com");

            IWebElement field = driver.FindElement(By.Id("gh-ac"));
            Assert.IsNotNull(field);

            driver.Quit();
        }

        [TestMethod]
        public void Test2_search()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ebay.com");

            IWebElement button = driver.FindElement(By.Id("gh-btn"));
            Assert.IsNotNull(button);

            driver.Quit();
        }
    }
}
