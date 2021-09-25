using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace NetSelenium1
{
    public class Dropdownlist
    {
        [Test]
        public void TestPage()
        {

            IWebDriver driver = new ChromeDriver(@"D:\vidapogosoft\cursos\2021\SINERGIASS\Workshop092021\Herramientas\");

            driver.Navigate().GoToUrl("http://www.tizag.com/phpT/examples/formex.php");

            driver.Manage().Window.Maximize();

            IWebElement control = driver.FindElement(By.Name("Fname"));
            control.SendKeys("VPR - 1");

            driver.FindElement(By.Name("Lname")).SendKeys("vidapogosoft");

            driver.FindElement(By.XPath("//input[@name='gender' and @value='Male']")).Click();

            driver.FindElement(By.XPath("//input[@name='food[]' and @value='Chicken']")).Click();

            driver.FindElement(By.Name("quote")).Clear();

            driver.FindElement(By.Name("quote")).SendKeys("Be Present!");

            // select the drop down list
            var education = driver.FindElement(By.Name("education"));
            var selectElement = new SelectElement(education);
            //select by value
            selectElement.SelectByValue("Jr.High");

            Thread.Sleep(5000);

            selectElement.SelectByText("HighSchool");


            Thread.Sleep(3000);


            //Take Foto

            ITakesScreenshot foto = driver as ITakesScreenshot;

            Screenshot screen = foto.GetScreenshot();

            screen.SaveAsFile(@"D:\vidapogosoft\cursos\2021\SINERGIASS\Workshop092021\Herramientas\" + DateTime.Now.Ticks.ToString() + ".png");


        }

    }
}
