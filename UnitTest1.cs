using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutoQaBlankForm
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "http://qaauto.co.nz/test-blank-form/";

        }

        [Test]

        public void Start()
        {
            QaFormLogin();
            LoginPage();

        }
        public void QaFormLogin()
        {
            IWebElement passwd = driver.FindElement(By.CssSelector("#wpforms-locked-16-field_form_locker_password"));
            passwd.SendKeys("Testing");
            IWebElement submit = driver.FindElement(By.CssSelector("#wpforms-submit-locked-16"));
            submit.Click();
        }
        public void LoginPage()
        {
            IWebElement name = driver.FindElement(By.CssSelector("#wpforms-16-field_0"));
            name.SendKeys("Tom");
            IWebElement last = driver.FindElement(By.CssSelector("#wpforms-16-field_0-last"));
            last.SendKeys("Luke");
            IWebElement email = driver.FindElement(By.CssSelector("#wpforms-16-field_1"));
            email.SendKeys("tom.luke@gmail.com");
            IWebElement comment = driver.FindElement(By.CssSelector("#wpforms-16-field_2"));
            comment.SendKeys("Good luck");
            IWebElement subtbutton = driver.FindElement(By.CssSelector("#wpforms-submit-16"));
            subtbutton.Click();
        }

        [TearDown]
        public void close()
        {
            driver.Close();

        }
        

    }
}