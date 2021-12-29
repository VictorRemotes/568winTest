package com.herokuapp.theinternet.base;

import org.apache.logging.log4j.Logger;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.testng.Assert;
import org.testng.annotations.Test;

public class SeleniumWebDriver {

    @Test
    public void testGoogle(){
        WebDriver driver = new ChromeDriver();
        driver.get("http://www.yahoo.com.tw");

        String ExpectedTitle = "Yahoo奇摩";

        String ActualTitle = driver.getTitle();

        System.out.println("預計顯示的Title： " + ExpectedTitle);

        Assert.assertEquals(ActualTitle, ExpectedTitle);

        System.out.println("實際顯示的Title： " + ActualTitle);

    }
}
