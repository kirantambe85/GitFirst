using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;
using MoorepayDemo.Utils;
using TechTalk.SpecFlow.Assist;
using System.Collections.Generic;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;

namespace MoorepayDemo.Steps
{
    [TestFixture]
    [AllureNUnit]
    [AllureDisplayIgnored]
    [Binding]
    public class LoginFeatureSteps
    {
        [Given(@"that I am at the NextGen's Login Page")]
        public void GivenUserIsAtTheLoginPage()
        {
            Objects.PoLogin.GotoUrl();
        }

        [When(@"I enter UserName and Password")]
        public void WhenUserEnterUserNameAndPassword()
        {
            Objects.PoLogin.EnterDetails();
        }

        [When(@"I click LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            Objects.PoLogin.LoginClick();            
        }
        
        [Then(@"Then I should be at the NextGen's portal page")]
        public void ThenThenIShouldBeAtTheNextGenSPortalPage()
        {
            Objects.PoLogin.VerifyPortalPage();
        }

        [When(@"I leave the username blank")]
        public void WhenILeaveTheUsernameBlank()
        {
            Objects.PoLogin.EnterUsername(string.Empty);
        }

        [When(@"I fill the username with ""(.*)""")]
        public void WhenIFillTheUsernameWith(string strUsername)
        {
            Objects.PoLogin.EnterUsername(strUsername);
        }

        [When(@"I leave the password blank")]
        public void WhenILeaveThePasswordBlank()
        {
            Objects.PoLogin.EnterPassword(string.Empty);
        }

        [When(@"I fill the password with ""(.*)""")]
        public void WhenIFillThePasswordWith(string strPassword)
        {
            Objects.PoLogin.EnterPassword(strPassword);
        }        

        [Then(@"a text '(.*)' should appear in the validation errors region")]
        public void ThenATextShouldAppearInTheValidationErrorsRegion(string strMessage)
        {
            Objects.PoLogin.VerifyMessage(strMessage);
        }

        [When(@"I enter following credentials and click login button")]
        public void WhenIEnterFollowingCredentialsAndClickLoginButton(Table table)
        {
            var credentials = table.CreateSet<LoginCredentials>();
            
            foreach (LoginCredentials row in credentials)
            {
                Objects.PoLogin.EnterUsername(row.Username);
                Objects.PoLogin.EnterPassword(row.Password);
                Objects.PoLogin.LoginClick();
            }
        }

        [Then(@"appropriate message or page should get displayed")]
        public void ThenAppropriateMessageOrPageShouldGetDisplayed()
        {
            Console.WriteLine("Test");
        }


    }
}
