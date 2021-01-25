using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoQaBlankForm.Pages
{
    class LoginPage
    {
        IWebDriver driver;
        By password = By.CssSelector("#wpforms-locked-16-field_form_locker_password");
        By submit = By.CssSelector("#wpforms-submit-locked-16");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;

        }
        //set pswd
        public void Setpassword(string strpassword)
        {
            driver.FindElement(password).SendKeys(strpassword);
        }
        //click login btn
        public void clickLogin()
        {
            driver.FindElement(submit).Click();
        }
        public void Login(string strpassword)
        {
            //fill pswd
            this.Setpassword(strpassword);
            //click submit
            this.clickLogin();
        }
    }
}
