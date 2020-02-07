using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject_PcTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver m_driver;
            m_driver = new ChromeDriver(@"E:\chromedriver");
            m_driver.Url = "http://demo.guru99.com/test/guru99home/";
            m_driver.Manage().Window.Maximize();
            IWebElement link = m_driver.FindElement(By.XPath(".//*[@id='rt-header']//div[2]/div/ul/li[2]/a"));
            link.Click();
            m_driver.Close();
        }
    }
}
