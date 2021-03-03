using GANTest.Core.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using GANTest.Core.Drivers;
using System.Threading;

namespace GANTest.StepDefinitions
{
    [Binding]
    public class StepDefinitions
    {
        [BeforeScenario]
        public void Initialize()
        {
            new Driver().Initialize();
        }

        [AfterScenario]
        public void CleanUp()
        {
            new Driver().CleanUp();
        }

        #region Given

        [Given(@"I am on the account registration page")]
        public void GivenIAmOnTheAccountRegistrationPage()
        {
            Driver.TestDriver.Navigate().GoToUrl("https://moneygaming.qa.gameaccount.com/sign-up.shtml");
        }

        #endregion Given

        #region When

        [When(@"I select ""(.*)"" in the title dropdown")]
        public void WhenISelectInTheTitleDropdown(string title)
        {
            AccountRegistrationPage accountRegistrationPage = new AccountRegistrationPage(Driver.TestDriver);
            accountRegistrationPage.SelectTitle(title);
        }

        [When(@"I introduce my name as ""(.*)""")]
        public void WhenIIntroduceMyNameAs(string name)
        {
            string[] names = name.Split(' ');
            AccountRegistrationPage accountRegistrationPage = new AccountRegistrationPage(Driver.TestDriver);
            accountRegistrationPage.InputName(names[0], names[1]);
        }

        [When(@"I check the checkbox confirming that I accept the Terms and Conditions and am over 18")]
        public void WhenICheckTheCheckboxConfirmingThatIAcceptTheTermsAndConditionsAndAmOver18()
        {
            AccountRegistrationPage accountRegistrationPage = new AccountRegistrationPage(Driver.TestDriver);
            accountRegistrationPage.SelectTandCCheckbox();
        }

        [When(@"I click on the JOIN NOW button")]
        public void WhenIClickOnTheJOINNOWButton()
        {
            AccountRegistrationPage accountRegistrationPage = new AccountRegistrationPage(Driver.TestDriver);
            accountRegistrationPage.ClickJoinNow();
        }

        #endregion When

        #region Then

        [Then(@"I can see ""(.*)"" under the Date of Birth box")]
        public void ThenICanSeeUnderTheDateOfBirthBox(string validationError)
        {
            AccountRegistrationPage accountRegistrationPage = new AccountRegistrationPage(Driver.TestDriver);
            Assert.IsTrue(accountRegistrationPage.AssertAgeValidationError(validationError)); 
        }

        #endregion Then




    }
}
