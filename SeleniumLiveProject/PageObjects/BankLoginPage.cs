using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit;
using NUnit.Framework;

namespace SeleniumLiveProject.PageObjects
{
    internal class BankLoginPage : BasePage
    {
        public BankLoginPage(IWebDriver driver) : base(driver) { }

        private By userIdField = By.Name("uid");
        private By passwordField = By.Name("password");
        private By loginButton = By.Name("btnLogin");
        private By managerId = By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[3]/td");
        

        internal void VisitBankLoginPage()
        {
            Visit("/V4/index.php");
        }

        internal void EnterLoginCredentials()
        {
            Type("mngr135630", Find(userIdField));
            Type("avUtyzY", Find(passwordField));
        }

        internal void SelectLogin()
        {
            Click(loginButton);
        }

        internal void VerifyLogin()
        {
            Find(managerId);
            Assert.AreEqual("Manger Id : mngr135630", ReadElementText(Find(managerId)));
        }
    }
}