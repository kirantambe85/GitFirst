using MoorepayDemo.Utils;
using System;
using TechTalk.SpecFlow;

namespace MoorepayDemo.Steps
{
    [Binding]
    public class RedirectToCompanySteps : Start
    {
        [Given(@"I am logged in Ingenta application and user is redirected to dashboard")]
        public void GivenIAmLoggedInIngentaApplicationAndUserIsRedirectedToDashboard()
        {
            Objects.PoDashboard.DashboardVerify();
        }
        
        [When(@"I navigate to Companies from dashboard")]
        public void WhenINavigateToCompaniesFromDashboard()
        {
            Objects.PoDashboard.navigateToCompany();
        }
        
        [When(@"I click Company link from menu option")]
        public void WhenIClickCompanyLinkFromMenuOption()
        {
            Objects.PoDashboard.ClickCompanyFromMenu();
        }
        
        [Then(@"search company page details should be displayed")]
        public void ThenSearchCompanyPageDetailsShouldBeDisplayed()
        {
            Objects.PoDashboard.verifySearchPageElements();
        }
    }
}
