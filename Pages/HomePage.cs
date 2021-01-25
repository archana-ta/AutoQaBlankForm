using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoQaBlankForm.Pages
{
    class HomePage
    {
        //doubt is need to give homepage xpath???

        IWebDriver driver;
            By name = By.CssSelector("#wpforms-16-field_0");        
            By last = By.CssSelector("#wpforms-16-field_0-last");        
            By email = By.CssSelector("#wpforms-16-field_1");        
            By comment = By.CssSelector("#wpforms-16-field_2");        
            By subtbutton = By.CssSelector("#wpforms-submit-16");
        

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        //set input values;
        public void Setname(string strname)
        {
            driver.FindElement(name).SendKeys(strname);
        }
        public void Setlast(string strlast)
        {
            driver.FindElement(last).SendKeys(strlast);
        }
        public void Setemail(string stremail)
        {
            driver.FindElement(email).SendKeys(stremail);
        }
        public void Setcomment(string strcomment)
        {
            driver.FindElement(comment).SendKeys(strcomment);
        }
        //click submit formdetails

        public void clicksubmit()
        {
            driver.FindElement(subtbutton).Click();
        }
        public void Home(string strname,string strlast,string stremail,string strcomment)
        {
            this.Setname(strname);
            this.Setlast(strlast);
            this.Setemail(stremail);
            this.Setcomment(strcomment);

            this.clicksubmit();
                

        }

    }
}
