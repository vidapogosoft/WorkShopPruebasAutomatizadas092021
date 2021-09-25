using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using System;
using System.Threading;


namespace NetSelenium1
{
    [TestClass]
    public class UnitTest1
    {
        //Se Inicializa el driver de manera global
        public IWebDriver driver = new ChromeDriver(@"D:\vidapogosoft\cursos\2021\SINERGIASS\Workshop092021\Herramientas\");
        
        //intancia de manera global la URL de la pagian a testear
        public string url = "https://admin-sysnnova.com/OpenFact/Account/Login.aspx";

        //generacion del metodo de prueba
        [TestMethod]
        public void Registro()
        {
           
                //seteo de la pagina a probar 
                driver.Navigate().GoToUrl(url);
                //se maximiza la pagina 
                driver.Manage().Window.Maximize();
                
                //instancia del campo para login campo USER
                driver.FindElement(By.Id("LoginUser_UserName"));
                driver.FindElement(By.Id("LoginUser_UserName")).Click();
                driver.FindElement(By.Id("LoginUser_UserName")).SendKeys("Demo");

                //instancia del campo para login campo PASS
                driver.FindElement(By.Id("LoginUser_Password"));
                driver.FindElement(By.Id("LoginUser_Password")).Click();
                driver.FindElement(By.Id("LoginUser_Password")).SendKeys("0430");

                //Pausa para procerder a dar click 
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

                Thread.Sleep(4000);

                //Click en login 
                driver.FindElement(By.Id("LoginUser_LoginButton")).Click();

                //Hasta este momento logueo exitoso
            
                WebDriverWait wait2 = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

                driver.FindElement(By.Id("liClientes")).Click();
                Thread.Sleep(3000);
                WebDriverWait wait3 = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

                driver.FindElement(By.Id("MainContent_btnAdd")).Click();
                Thread.Sleep(2000);
                WebDriverWait wait4 = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

                driver.FindElement(By.Id("MainContent_txtNombreCliente"));
                driver.FindElement(By.Id("MainContent_txtNombreCliente")).Click();
                driver.FindElement(By.Id("MainContent_txtNombreCliente")).SendKeys("DPR-4");
                Thread.Sleep(2000);

                //var tipoIdent = Driver.FindElement(By.Id("MainContent_ddlTipoIdentificacion"));
                //var selectElement = new SelectElement(tipoIdent);
                //selectElement.SelectByText("C�dula");

                var TipoIdent = driver.FindElement(By.Id("MainContent_ddlTipoIdentificacion"));
                var selectElement = new SelectElement(TipoIdent);
                selectElement.SelectByValue("05");
                Thread.Sleep(2000);

                driver.FindElement(By.Id("MainContent_txtIdentificacion"));
                driver.FindElement(By.Id("MainContent_txtIdentificacion")).Click();
                driver.FindElement(By.Id("MainContent_txtIdentificacion")).SendKeys("0959143926");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("MainContent_txtTelefonoConvencional"));
                driver.FindElement(By.Id("MainContent_txtTelefonoConvencional")).Click();
                driver.FindElement(By.Id("MainContent_txtTelefonoConvencional")).SendKeys("045114449");
                Thread.Sleep(2000);

                driver.FindElement(By.Id("MainContent_txtDireccion"));
                driver.FindElement(By.Id("MainContent_txtDireccion")).Click();
                driver.FindElement(By.Id("MainContent_txtDireccion")).SendKeys("Direccion de domicilio");
                Thread.Sleep(2000);

                IWebElement Check1 = driver.FindElement(By.Id("MainContent_cbxEnviarBienvenida"));
                Check1.Click();


                driver.FindElement(By.Id("MainContent_txtMailDefecto")).SendKeys("correo1@dominio.com");
                driver.FindElement(By.Id("MainContent_txtCorreosCopiaCliente")).SendKeys("correo2@dominio.com");


                Thread.Sleep(2000);

                driver.FindElement(By.Id("MainContent_btnGuardarCliente")).Click();

                Thread.Sleep(5000);

               this.driver.SwitchTo().Alert().Accept();
            
        }
    }
}