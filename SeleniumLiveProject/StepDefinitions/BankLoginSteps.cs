using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

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
            ScenarioContext.Current.Pending();
        }

        [Given(@"I enter in valid credentials")]
        public void GivenIEnterInValidCredentials()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click Login")]
        public void WhenIClickLogin()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
