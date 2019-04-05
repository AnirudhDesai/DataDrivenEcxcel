using DataDriverTestProject.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using W3SchoolsProject;
using W3SchoolsProject.Settings;

namespace DataDriverTestProject
{
    [Binding]
    public class W3SchoolsScenarioSteps
    {

        private W3SchoolsHomePage homepage;
        private LearnHtmlPage learnpage;
        private Run run;
        [Given]
        public void GivenIAmOnW_P0_SchoolsWebpage(int p0)
        {
            homepage = new W3SchoolsHomePage();
            W3SchoolsHomePage.NavigatetoW3schools();

        }
        
        [Given]
        public void GivenIAmOnLearnHtmlWebpage()
        {
            learnpage = new LearnHtmlPage(ObjectRepository.Driver);
           
        }
        
        [Given]
        public void GivenIAmAtTryItYourselfWorkSpace()
        {
            run = new Run(ObjectRepository.Driver);
        }
        
        [When]
        public void WhenIClickOnLearnHtmlLink()
        {
            ObjectRepository.Driver=homepage.ClickLearnHtmllink();
        }
        
        [When]
        public void WhenClickOnTryItYourselfButton()
        {
            ObjectRepository.Driver=learnpage.Tryityourself();
        }
        
        [When]
        public void WhenIClickOnRunButton()
        {
            run.Tryityourself();
        }
        
        [Then]
        public void ThenPageShouldRedirectToHttpsWwwW_P0_SchoolsComHtmlDefaultAsp(int p0)
        {
            Assert.IsNotNull(ObjectRepository.Driver.FindElement(By.XPath("//*[@id='main']")));
        }
        
        [Then]
        public void ThenPageShouldNavigateToUrlHttpsWwwW_P0_SchoolsComHtmlTryitAspFilenameTryhtml_default(int p0)
        {
            Assert.IsNotNull(ObjectRepository.Driver.FindElement(By.XPath("/html/body/div[5]/div")));
        }
        
        [Then]
        public void ThenTheOutputShouldHave_P0_And_P1_Tags(string p0, string p1)
        {
            Assert.IsNotNull(ObjectRepository.Driver.FindElement(By.XPath("/html/body/h1")));
        }
    }
}
