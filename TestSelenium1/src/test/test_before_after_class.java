package test;

import org.junit.*;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;


public class test_before_after_class {

    private static WebDriver driver = null;

    @BeforeClass
    public static void OpenBrowser()
    {
        System.out.print("Browser Open");

        System.setProperty("webdriver.chrome.driver"
                ,"D:\\vidapogosoft\\cursos\\2021\\SINERGIASS\\Workshop092021\\Herramientas\\chromedriver.exe");


        driver  = new ChromeDriver();
        driver.manage().window().maximize();
        driver.get("http://www.sysnnovasolutions.com/");


    }

    @AfterClass
    public static void CloseBrowser()
    {
        System.out.print("\nBrowser close");
        System.out.print("\nFinaliza todo el proceso");

        driver.quit();

    }


    @Test
    public void TestAssert1()
    {
        System.out.println(driver.getCurrentUrl());
        System.out.println(driver.getTitle());

        String ActualTitle = driver.getTitle();

        String ExpectedTitle = "Sysnnova Solutions";

        Assert.assertEquals(ActualTitle, ExpectedTitle);
    }

    @Test
    public void TestAssert2()
    {
        System.out.println(driver.getCurrentUrl());
        System.out.println(driver.getTitle());

        String ActualTitle = driver.getTitle();

        //String ExpectedTitle = "Sysnnova Solutions";

        String ExpectedTitle = "BizCraft - responsive";

        Assert.assertEquals(ActualTitle, ExpectedTitle);

    }

}
