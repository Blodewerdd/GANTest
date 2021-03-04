using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace GANTest.Core.Pages
{
    class AccountRegistrationPage
    {
        public IWebDriver testDriver;

        public AccountRegistrationPage(IWebDriver driver)
        {
            this.testDriver = driver;
        }

        #region Locators 

        const string _titleDropDown = "title";
        const string _firstNameField = "forename";
        const string _lastNameField = "map(lastName)";
        const string _TandCCheckbox = "map(terms)";
        const string _joinNowButton = "form";
        const string _ageValidationMessage = "//label[@for='dob'][@class='error']";

        #endregion Locators

        #region Elements

        IWebElement TitleDropDown => testDriver.FindElement(By.Id(_titleDropDown));
        IWebElement FirstNameField => testDriver.FindElement(By.Id(_firstNameField));
        IWebElement LastNameField => testDriver.FindElement(By.Name(_lastNameField));
        IWebElement TandCCheckbox => testDriver.FindElement(By.Name(_TandCCheckbox));
        IWebElement JoinNowButton => testDriver.FindElement(By.Id(_joinNowButton));
        IWebElement AgeValidationMessage => testDriver.FindElement(By.XPath(_ageValidationMessage));





        #endregion Elements

        #region Methods

        public void SelectTitle(string title)
        {
            SelectElement SelectTitle = new SelectElement(TitleDropDown);
            SelectTitle.SelectByValue(title);
        }

        public void InputName(string firstName, string lastName)
        {
            FirstNameField.SendKeys(firstName);
            LastNameField.SendKeys(lastName);
        }

        public void SelectTandCCheckbox()
        {
            TandCCheckbox.Click();
        }

        public void ClickJoinNow()
        {
            JoinNowButton.Click();
        }

        public bool AssertAgeValidationError(string error)
        {
            new WebDriverWait(testDriver, new TimeSpan(0, 0, 10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(_ageValidationMessage)));
            return Equals(error, AgeValidationMessage.Text);
        }

        #endregion Methods
    }
}
