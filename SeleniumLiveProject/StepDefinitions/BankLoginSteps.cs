using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SeleniumLiveProject.PageObjects;

namespace SeleniumLiveProject.StepDefinitions
{
    [Binding]
    class BankLoginSteps : BaseSteps
    {
        private readonly ScenarioContext scenarioContext;

        public BankLoginSteps(ScenarioContext scenarioContext)
        {
            if (scenarioContext == null) throw new ArgumentNullException("scenarioContext");
            this.scenarioContext = scenarioContext;
        }
        [BeforeScenario("BankLogin")]
        public void BeforeBankLoginScenario()
        {
            LoadConfigValues();
            CheckBrowser();
            scenarioContext["Driver"] = Driver;
        }
        [AfterScenario("BankLogin")]
        public void AfterBankLoginScenario()
        {
            Driver.Close();
            Driver.Dispose();
            Driver.Dispose();
        }

        [Given(@"I am on the Bank Login Page")]
        public void GivenIAmOnTheBankLoginPage()
        {
            BankLoginPage bankLoginPage = new BankLoginPage(Driver);
            bankLoginPage.VisitBankLoginPage();
        }

        [Given(@"I enter in valid credentials")]
        public void GivenIEnterInValidCredentials()
        {
            BankLoginPage bankLoginPage = new BankLoginPage(Driver);
            bankLoginPage.EnterLoginCredentials();
        }

        [When(@"I select Login")]
        public void WhenISelectLogin()
        {
            BankLoginPage bankLoginPage = new BankLoginPage(Driver);
            bankLoginPage.SelectLogin();
        }

        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            BankLoginPage bankLoginPage = new BankLoginPage(Driver);
            bankLoginPage.VerifyLogin();
        }

    }
}
