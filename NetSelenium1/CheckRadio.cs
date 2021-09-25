using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;



namespace NetSelenium1
{
    public class CheckRadio
    {

        [Test]
        public void Test1()
        {

            IWebDriver driver = new ChromeDriver(@"D:\vidapogosoft\cursos\2021\SINERGIASS\Workshop092021\Herramientas\");

            driver.Navigate().GoToUrl("http://demo.guru99.com/test/radio.html");

            driver.Manage().Window.Maximize();

            Thread.Sleep(4000);

            // Se localiza los radio button por su id

            IWebElement radio1 = driver.FindElement(By.Id("vfb-7-1"));

            IWebElement radio2 = driver.FindElement(By.Id("vfb-7-2"));

            IWebElement radio3 = driver.FindElement(By.Id("vfb-7-3"));

            radio1.Click();

            Thread.Sleep(6000);

            radio2.Click();

            Thread.Sleep(6000);

            radio3.Click();

            IWebElement Check1 = driver.FindElement(By.Id("vfb-6-0"));

            // Se localiza el segundo radio button por su id
            IWebElement Check2 = driver.FindElement(By.Id("vfb-6-2"));

            Check1.Click();

            Thread.Sleep(6000);
            //El radio button 1 es deseleccionado y el segundo es seleccionado
            Check2.Click();

        }

    }
}
