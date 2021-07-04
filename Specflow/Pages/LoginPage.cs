using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowMars.Pages
{
    class LoginPage
    {
        public IWebDriver Driver { get; }

        public By SignIn = By.XPath("//a[text()='Sign In']");
        public By Email = By.XPath("//input[@placeholder='Email address']");
        public By Password = By.XPath("//input[@placeholder='Password']");

        public By LoginBtn = By.XPath("//button[text()='Login']");
 
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;   
        }

        public void Login()
        {
            Driver.FindElement(SignIn).Click();
            Driver.FindElement(Email).SendKeys("rishavsrivastava9@gmail.com");
            Driver.FindElement(Password).SendKeys("Richard");
            Driver.FindElement(LoginBtn).Click();
        }
    }
}
