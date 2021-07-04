using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowMars.Pages
{
    class ProfilePage
    {
        public IWebDriver Driver { get; }

        // Page object for 1st Scenario

        public By Description = By.XPath("//span/i[@class='outline write icon']");
        public By TextArea = By.XPath("//textarea[@name='value']");
        public By SaveBtn = By.XPath("//button[@type='button']");

        public By DescriptionSuccess = By.XPath("//div[@class='ns-box-inner']");

        // Page object model for 2nd scenario
        public By Availability = By.XPath("(//span/i[@class='right floated outline small write icon'])[1]");
        public By Hours = By.XPath("(//span/i[@class='right floated outline small write icon'])[2]");
        public By Earn = By.XPath("(//span/i[@class='right floated outline small write icon'])[3]");

        public By AvailabilityElement = By.XPath("//select[@name='availabiltyType']");
        public By HoursElement = By.XPath("//select[@name='availabiltyHour']");
        public By EarnElement = By.XPath("//select[@name='availabiltyTarget']");

        public By AvailabilityElementDrop = By.XPath("//select[@name='availabiltyType']/option[text()='Part Time']");
        public By HoursElementDrop = By.XPath("//select[@name='availabiltyHour']/option[text()='As needed']");
        public By EarnElementDrop = By.XPath("//select[@name='availabiltyTarget']/option[text()='More than $1000 per month']");

        public By AvailDisplayedText = By.XPath("(//div[@class='right floated content']/span)[1]");
        public By HoursDisplayedText = By.XPath("(//div[@class='right floated content']/span)[2]");
        public By EarnTargetDisplayedText = By.XPath("(//div[@class='right floated content']/span)[3]");

        //Page object for 3rd Scenario

        public By Languages = By.XPath("//a[text()='Languages']");
        public By AddBtn = By.XPath("//div[text()='Add New']");
        public By LanguageText = By.XPath("//input[@placeholder='Add Language']");
        public By LanguageDrop = By.XPath("//select");
        public By LanguageDropDown = By.XPath("//select/option[@value='Fluent']");
        public By AddLanguageBtn = By.XPath("//input[@value='Add']");
        public By AddSuccess = By.XPath("//div[text()='English has been added to your languages']");

        public ProfilePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void SendDecription()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Driver.FindElement(Description).Click();
            Driver.FindElement(TextArea).SendKeys("Hi I have 4 years of experience in automation testing");
            Driver.FindElement(SaveBtn).Click();
        }

        public String DescriptionText()
        {
            String Text = Driver.FindElement(DescriptionSuccess).Text;
            return Text;
        }

        public void DashBoard()
        {
            Driver.FindElement(Availability).Click();
            Driver.FindElement(AvailabilityElement).Click();
            Driver.FindElement(AvailabilityElementDrop).Click();

            Driver.FindElement(Hours).Click();
            Driver.FindElement(HoursElement).Click();
            Driver.FindElement(HoursElementDrop).Click();

            Driver.FindElement(Earn).Click();
            Driver.FindElement(EarnElement).Click();
            Driver.FindElement(EarnElementDrop).Click();
        }

        public String AvailabilityText()
        {
            String AvailabilityText = Driver.FindElement(AvailDisplayedText).Text;
            return AvailabilityText;
        }


        public String HoursText()
        {
            String HoursText = Driver.FindElement(HoursDisplayedText).Text;
            return HoursText;
        }

        public String EarnTargetText()
        {
            String EarnTarget = Driver.FindElement(EarnTargetDisplayedText).Text;
            return EarnTarget;
        }

        public void AddLanguage()
        {
            Driver.FindElement(Languages).Click();
            Driver.FindElement(AddBtn).Click();
            Driver.FindElement(LanguageText).SendKeys("English");
            Driver.FindElement(LanguageDrop).Click();
            Driver.FindElement(LanguageDropDown).Click();
            Driver.FindElement(AddLanguageBtn).Click();
        }

        
        public String LanguageValidation()
        {
            String SuccessText = Driver.FindElement(AddSuccess).Text;
            return SuccessText;
        }


    }
}
