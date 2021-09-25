package test;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

import org.openqa.selenium.*;
import org.openqa.selenium.By;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.interactions.Actions;


public class TestClass {

    private static WebDriver driver = null;

    public static void main(String[] args)
    {

        try {

            System.out.println("defino la ruta del exe a utilizar");

        System.setProperty("webdriver.chrome.driver"
                ,"D:\\vidapogosoft\\cursos\\2021\\SINERGIASS\\Workshop092021\\Herramientas\\chromedriver.exe");


        System.out.println("definir el driver de selenium");

        driver = new ChromeDriver();
        driver.manage().window().maximize();

        System.out.println("inicio la navegacion hacia el browser");

        driver.get("https://demoqa.com/automation-practice-form");

        System.out.println("inicio del ingreso de datos");

        driver.findElement(By.id("firstName")).sendKeys("VPR");
        driver.findElement(By.id("lastName")).sendKeys("Portugal");

            driver.findElement(By.id("currentAddress")).sendKeys("GYE - AVENIDA MIRAFLORES");
            driver.findElement(By.id("userNumber")).sendKeys("0960578556");
            driver.findElement(By.id("userEmail")).sendKeys("vpr@email.com");

        //radio button

        WebElement radioBtnMale = driver.findElement(By.id("gender-radio-1"));
        ((JavascriptExecutor) driver).executeScript("arguments[0].checked = true", radioBtnMale);

        //checkbox
        //hobbies-checkbox-1
        //hobbies-checkbox-3

        WebElement ChkHobbie1 = driver.findElement(By.id("hobbies-checkbox-1"));
        ((JavascriptExecutor) driver).executeScript("arguments[0].checked = true", ChkHobbie1);

        WebElement ChkHobbie3 = driver.findElement(By.id("hobbies-checkbox-3"));
        ((JavascriptExecutor) driver).executeScript("arguments[0].checked = true", ChkHobbie3);

        //dateOfBirthInput

        //no funciono
        //driver.findElement(By.id("dateOfBirthInput")).sendKeys("12-10-1980");

        //   //*[@id='dateOfBirthInput']
        Actions actions = new Actions(driver);
        actions.moveToElement(driver.findElement(By.xpath("//*[@id='dateOfBirthInput']")));
        actions.click();

        actions.sendKeys(Keys.BACK_SPACE).sendKeys(Keys.BACK_SPACE)
                .sendKeys(Keys.BACK_SPACE).sendKeys(Keys.BACK_SPACE)
                .sendKeys(Keys.BACK_SPACE).sendKeys(Keys.BACK_SPACE)
                .sendKeys(Keys.BACK_SPACE).sendKeys(Keys.BACK_SPACE)
                .sendKeys(Keys.BACK_SPACE).sendKeys(Keys.BACK_SPACE);

        Thread.sleep(3000);

        actions.sendKeys("1980-12-10");
        actions.sendKeys(Keys.ESCAPE);
        actions.build().perform();

        WebElement updElement = driver.findElement(By.id("uploadPicture"));
        updElement.sendKeys("D:\\vidapogosoft\\cursos\\2021\\SINERGIASS\\Workshop092021\\Herramientas\\nbaspring.png"); //ruta de donde obtengo la imagen

            WebElement Select1 = driver.findElement(By.id("react-select-3-input"));
            Select1.sendKeys("NCR");
            Select1.sendKeys(Keys.TAB);


            WebElement Select2 = driver.findElement(By.id("react-select-4-input"));
            Select2.sendKeys("Delhi");
            Select2.sendKeys(Keys.TAB);


            driver.findElement(By.id("submit")).click();

            System.out.println("cerrar");


    } catch (InterruptedException e) {
        e.printStackTrace();
    }


    }


}
