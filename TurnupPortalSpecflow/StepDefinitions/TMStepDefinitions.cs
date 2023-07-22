using System;
using System.Diagnostics;
using System.Reflection.Emit;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using TurnupPortalSpecflow.Pages;
using TurnupPortalSpecflow.Utilities;
using static TurnupPortalSpecflow.Pages.Home;

namespace TurnupPortalSpecflow.StepDefinitions
{
    [Binding]
    public class TMStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        LoginPage loginPageObject = new LoginPage();
        HomePage homePageObject = new HomePage();
        TM_page tmPageObject = new TM_page();
        Wait wait = new Wait();

        [Given(@"I log into turnup portal")]
        public void GivenILogIntoTurnupPortal()
        {
            loginPageObject.LoginSteps(driver);
        }

        [When (@"I navigate to the Time and material page")]
        public void GivenINavigateToTheTimeAndMaterialPage()
        {
            homePageObject.GoToTMPage(driver);
        }


        [When(@"I create a new Time and material record '([^']*)'  '([^']*)'  '([^']*)'")]
        public void WhenICreateANewTimeAndMaterialRecord(String code, String description, String price)
        {
            tmPageObject.CreateTimeRecord(driver, code, description, price);
        }

        [Then(@"the record should be saved '([^']*)'")]
        public void ThenTheRecordShouldBeSaved(String code)
        {
            tmPageObject.AssertCreateTimeRecord(driver, code);
            driver.Quit();
        }

        [When(@"I edit a new Time and material record '([^']*)'  '([^']*)'")]
        public void WhenIEditANewTimeAndMaterialRecord(String oldCode, String newCode)
        {
            tmPageObject.EditTimeRecord(driver, oldCode, newCode);
        }

        [Then(@"the record should be updated '([^']*)'")]
        public void ThenTheRecordShouldBeUpdated(String newCode)
        {
            tmPageObject.AssertEditTimeRecord(driver, newCode);
            driver.Quit();
        }

        [When(@"I delete Time and material record '([^']*)'")]
        public void WhenIDeleteTimeAndMaterialRecord(String newCode)
        {
            tmPageObject.DeleteTimeRecord(driver, newCode);
        }

        [Then(@"the record should be deleted  '([^']*)'")]
        public void ThenTheRecordShouldBeDeleted( String code)
        {
            tmPageObject.AssertDeleteTimeRecord(driver,code);
            driver.Quit();
        }

    }
}
