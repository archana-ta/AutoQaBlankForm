using AutoQaBlankForm.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoQaBlankForm.TestMethod
{
    class TestHome
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "http://qaauto.co.nz/test-blank-form/";

        }
        public void CreatTest()
        {
            LoginPage loginPage = new LoginPage(driver);

            HomePage homePage = new HomePage(driver);
           
        }

        

        
    }
}
