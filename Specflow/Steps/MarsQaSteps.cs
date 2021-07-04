using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowMars.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowMars.Steps
{
    [Binding]
    public sealed class MarsQaSteps
    {
        IWebDriver driver = new ChromeDriver();
        LoginPage loginPage = null;
        ProfilePage profilePage = null;

        [Given(@"User is able to login Mars QA website successfully")]
        public void GivenUserIsAbleToLoginMarsQAWebsiteSuccessfully()
        {
            
            driver.Navigate().GoToUrl("http://192.168.99.100:5000/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Window.Maximize();
            loginPage = new LoginPage(driver);
            loginPage.Login();
        }

        [When(@"User adds Description in the description tab")]
        public void WhenUserAddsDescriptionInTheDescriptionTab()
        {
            profilePage = new ProfilePage(driver);
            profilePage.SendDecription();

        }

        [Then(@"User is able to successfully add the Description")]
        public void ThenUserIsAbleToSuccessfullyAddTheDescription()
        {
            profilePage = new ProfilePage(driver);
            String Text = profilePage.DescriptionText();
            Assert.AreEqual("Description has been saved successfully", Text);
        }

        [When(@"User adds Availability,Hours and Earn Target")]
        public void WhenUserAddsAvailabilityHoursAndEarnTarget()
        {
            profilePage = new ProfilePage(driver);
            profilePage.DashBoard();
        }

        [Then(@"User is able to successfully add the Availability,Hours and Earn Target")]
        public void ThenUserIsAbleToSuccessfullyAddTheAvailabilityHoursAndEarnTarget()
        {
            profilePage = new ProfilePage(driver);
            String AvailText = profilePage.AvailabilityText();
            String HoursText = profilePage.HoursText();
            String EarnText = profilePage.EarnTargetText();

            Assert.AreEqual(AvailText, "Part Time");
            Assert.AreEqual(HoursText, "As needed"); 
            Assert.AreEqual(EarnText, "More than $1000 per month");
        }

        [When(@"User adds Languages and Skills")]
        public void WhenUserAddsLanguagesAndSkills()
        {
            profilePage = new ProfilePage(driver);
            profilePage.AddLanguage();
        }

        [Then(@"User is able to successfully add the Languages and Skills")]
        public void ThenUserIsAbleToSuccessfullyAddTheLanguagesAndSkills()
        {
            profilePage = new ProfilePage(driver);
            String Text = profilePage.LanguageValidation();
            Assert.AreEqual(Text, "English has been added to your languages");
        }

    }
}
