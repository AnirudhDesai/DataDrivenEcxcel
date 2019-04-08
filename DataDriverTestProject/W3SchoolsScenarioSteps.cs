using DataDriverTestProject.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using W3SchoolsProject;
using W3SchoolsProject.ComponentHelper;
using W3SchoolsProject.Settings;

namespace DataDriverTestProject
{
    [Binding]
    public class W3SchoolsScenarioSteps
    {
        private static LearnHtmlPage _learnpage;
        private static W3SchoolsHomePage homepage;
        private static LearnHtmlPage learnpage;
        private static IWebDriver driver;
        private static Run run;
        private static Run _run;

        [Given]
        public void GivenIAmOnWschoolsWebpage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            
            homepage = new W3SchoolsHomePage(ObjectRepository.Driver);
          
        }

        [Given]
        public void GivenIAmOnLearnHtmlWebpage()
        {
            _learnpage = learnpage;
        }

        [Given]
        public void GivenIAmAtTryItYourselfWorkSpace()
        {
            _run = run;
        }

        [When]
        public void WhenIClickOnLearnHtmlLink()
        {
            learnpage = homepage.ClickLearnHtmllink();
        }

        [When]
        public void WhenClickOnTryItYourselfButton()
        {
            run = learnpage.Tryityourself();
        }

        [When]
        public void WhenIClickOnRunButton()
        {
            run.Tryityourself();
        }

        [Then]
        public void ThenPageShouldRedirectTo_P0(string p0)
        {
            Assert.IsFalse(homepage.test());
        }

        [Then]
        public void ThenPageShouldNavigateToUrl_P0(string p0)
        {
            Assert.IsFalse(learnpage.test());
        }

        [Then]
        public void ThenTheOutputShouldHave_P0_And_P1_Tags(string p0, string p1)
        {
            Assert.IsNotNull(run.test());
        }
    }
}


