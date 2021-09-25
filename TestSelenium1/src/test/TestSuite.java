package test;

import org.junit.*;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;


public class TestSuite {

    @Test
    public void TestAssert1()
    {
        System.setProperty("webdriver.chrome.driver"
                ,"D:\\vidapogosoft\\cursos\\2021\\SINERGIASS\\Workshop092021\\Herramientas\\chromedriver.exe");

        WebDriver driver  = new ChromeDriver();
        driver.manage().window().maximize();
        driver.get("http://www.sysnnovasolutions.com/");

        System.out.println(driver.getCurrentUrl());
        System.out.println(driver.getTitle());

        String ActualTitle = driver.getTitle();

        String ExpectedTitle = "Sysnnova Solutions";

        Assert.assertEquals(ActualTitle, ExpectedTitle);

    }

    @Test
    public void TestAssert2()
    {

        System.setProperty("webdriver.chrome.driver"
                ,"D:\\vidapogosoft\\cursos\\2021\\SINERGIASS\\Workshop092021\\Herramientas\\chromedriver.exe");

        WebDriver driver  = new ChromeDriver();
        driver.manage().window().maximize();
        driver.get("https://admin-sysnnova.com/sysnnovasite/index.html");

        System.out.println(driver.getCurrentUrl());
        System.out.println(driver.getTitle());

        String ActualTitle = driver.getTitle();

        String ExpectedTitle = "Sysnnova Solutions";

        Assert.assertEquals(ActualTitle, ExpectedTitle);

    }

}
