

import org.apache.logging.log4j.Logger;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.testng.Assert;
import org.testng.annotations.Test;

public class SeleniumWebDriver {

    @Test
    public void testGoogle(){
        WebDriver driver = new ChromeDriver();
        driver.get("http://www.google.com.tw");

        String ExpectedTitle = "Google";

        String ActualTitle = driver.getTitle();

        System.out.println("Expected Display Title： " + ExpectedTitle);

        Assert.assertEquals(ActualTitle, ExpectedTitle);

        System.out.println("Actual Display Title： " + ActualTitle);

    }
}
