using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Testing6
{
    internal class NUnitDemo
    {
        IWebDriver webDriver;

        [SetUp]
        public void startBrowser()
        {
            webDriver = new ChromeDriver(@"C:\Program Files\Google\Chrome\Application\chrome.exe");
        }
        [TearDown] 
        public void stopBrowser()
        {
            webDriver.Quit();
        }
        [Test] 
        public void PaymentTest()
        {
            webDriver.Navigate().GoToUrl("http://localhost:8000/");
            //webDriver.Manage().Window.Size = new System.Drawing.Size(974, 1080);
            webDriver.FindElement(By.CssSelector(".catalog-box:nth-child(1) button")).Click();
            webDriver.FindElement(By.Id("buyer_firstname")).Click();
            webDriver.FindElement(By.Id("buyer_firstname")).SendKeys("sill");
            webDriver.FindElement(By.Id("buyer_lastname")).Click();
            webDriver.FindElement(By.Id("buyer_lastname")).SendKeys("sell");
            webDriver.FindElement(By.Id("buyer_email")).Click();
            webDriver.FindElement(By.Id("buyer_email")).SendKeys("sill@example.net");
            webDriver.FindElement(By.Id("buyer_phone")).Click();
            webDriver.FindElement(By.Id("buyer_phone")).SendKeys("000 000 0000");
            webDriver.FindElement(By.CssSelector("input:nth-child(6)")).Click();
            webDriver.FindElement(By.Id("cardNumber")).Click();
            webDriver.FindElement(By.Id("cardNumber")).SendKeys("4242 4242 4242 4242");
            webDriver.FindElement(By.Id("cardExpiry")).Click();
            webDriver.FindElement(By.Id("cardExpiry")).SendKeys("09 / 25");
            webDriver.FindElement(By.Id("cardCvc")).Click();
            webDriver.FindElement(By.Id("cardCvc")).SendKeys("123");
            webDriver.FindElement(By.Id("billingName")).Click();
            webDriver.FindElement(By.Id("billingName")).SendKeys("silleniumCard");
            webDriver.FindElement(By.CssSelector(".SubmitButton-CheckmarkIcon svg")).Click();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.That(webDriver.FindElement(By.CssSelector(".box-name")).Text, Is.EqualTo("Payment successful"));
        }

        [Test]
        public void CreateProductTest()
        {
            webDriver.Navigate().GoToUrl("http://localhost:8000/");
            webDriver.FindElement(By.LinkText("Log-in")).Click();
            webDriver.FindElement(By.Id("email")).SendKeys("ottis.lockman@example.net");
            webDriver.FindElement(By.Id("password")).SendKeys("password");
            webDriver.FindElement(By.Id("remember")).Click();
            webDriver.FindElement(By.CssSelector(".button-group > input")).Click();
            webDriver.FindElement(By.LinkText("My products")).Click();
            webDriver.FindElement(By.CssSelector(".mark-button > button")).Click();
            string filePath = @"C:\Users\artem\OneDrive\Університет\ЯПЗтаТ\Testing\Testing6\63361dc58da74.png";
            webDriver.FindElement(By.Id("image")).SendKeys(filePath);
            webDriver.FindElement(By.Id("name")).SendKeys("Sillemium product");
            webDriver.FindElement(By.Id("product_number")).SendKeys("9876542136837");
            webDriver.FindElement(By.Id("price")).SendKeys("99.25");
            webDriver.FindElement(By.Id("stock_quantity")).SendKeys("1");
            webDriver.FindElement(By.Id("description")).SendKeys("kjlsdfgklhdshfgksdjgsdgflsdjghlsdfgdskfj");
            webDriver.FindElement(By.CssSelector("div > input:nth-child(1)")).Click();
            webDriver.FindElement(By.CssSelector("div > input:nth-child(1)")).SendKeys("char 1");
            webDriver.FindElement(By.CssSelector(".product-option > div > input:nth-child(2)")).Click();
            webDriver.FindElement(By.CssSelector(".product-option > div > input:nth-child(2)")).SendKeys("val 1");
            webDriver.FindElement(By.CssSelector(".char-button")).Click();
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".product-option+div>.saved-char:nth-child(1)")));
            webDriver.FindElement(By.CssSelector("div > input:nth-child(1)")).Click();
            webDriver.FindElement(By.CssSelector("div > input:nth-child(1)")).SendKeys("char 2");
            webDriver.FindElement(By.CssSelector(".product-option > div > input:nth-child(2)")).Click();
            webDriver.FindElement(By.CssSelector(".product-option > div > input:nth-child(2)")).SendKeys("val 2");
            webDriver.FindElement(By.CssSelector(".char-button:nth-child(3)")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".product-option+div>.saved-char:nth-child(2)")));
            webDriver.FindElement(By.CssSelector("input:nth-child(11)")).Click();
            webDriver.FindElement(By.CssSelector(".table-search > input")).Click();
            webDriver.FindElement(By.CssSelector(".table-search > input")).SendKeys("sille");
            webDriver.FindElement(By.CssSelector(".table-search > button:nth-child(2) > img")).Click();
            Thread.Sleep(1000);
            webDriver.FindElement(By.CssSelector("body > section.content-section > div > div > div:nth-child(2) > div.cabinet-table > table > tbody > tr:nth-child(1) > td:nth-child(6) > form > button")).Click();
            webDriver.FindElement(By.CssSelector("li:nth-child(1) .extra-icon")).Click();
        }
    }
}
