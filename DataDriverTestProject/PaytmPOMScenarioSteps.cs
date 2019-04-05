using W3SchoolsProject;
using W3SchoolsProject.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject4
{
    [Binding]
    public class PaytmPOMScenarioSteps

    {
        IWebElement DTHlink;
        IWebElement metrolink;
        IWebElement electricitylink;
        IWebElement mobilelink;

        W3SchoolsHomePage w3schools = new W3SchoolsHomePage();

        [Given(@"I have entered Paytm website")]
        public void GivenIHaveEnteredPaytmWebsite()
        {
            w3schools.;
        }


        [Given(@"I click on Mobile option")]
        public void GivenIClickOnMobileOption()
        {
            w3schools.Mobilelinkclick();
        }

        [Given(@"also I have entered Mobile number and Amount")]
        public void GivenAlsoIHaveEnteredMobileNumberAndAmount()
        {
            w3schools.EnterMobileNumberandAmount();
        }

        [When(@"I click on Proceed Recharge Button")]
        public void WhenIClickOnProceedRechargeButton()
        {
            w3schools.Proceedtorecharge();
        }

        [When(@"fields like Mobile,Electricity,DTH,Metro are pesent")]
        public void WhenFieldsLikeMobileElectricityDTHMetroArePesent()
        {
           DTHlink = w3schools.DTHXpath();
            metrolink = w3schools.MetroXpath();
             electricitylink = w3schools.ElectricityXpath();
            mobilelink = w3schools.MobileXpath();

        }

        [Then(@"check all the corresponding fields are present or not")]
        public void ThenCheckAllTheCorrespondingFieldsArePresentOrNot()
        {
            Assert.IsNotNull(DTHlink);
            Assert.IsNotNull(metrolink);
            Assert.IsNotNull(electricitylink);
            Assert.IsNotNull(mobilelink);

        }
        


        [Then(@"Page should navigate to Url https://paytm\.com/recharge")]
        public void ThenPageShouldNavigateToUrlHttpsPaytm_ComRecharge()
        {
            Assert.AreEqual(w3schools.GetPaytmRechargeURl(), w3schools.GetCurrentUrl());
        }

        [Then(@"Page should Navigate to Proceed to Pay and Url should be https://paytm\.com/coupons")]
        public void ThenPageShouldNavigateToProceedToPayAndUrlShouldBeHttpsPaytm_ComCoupons()
        {
           // Assert.AreEqual(paytmPom.GetCouponsUrl(), paytmPom.GetCurrentUrl());


            // Assert.IsNotNull(paytmPom.GetXpathOfCoupnPage());
            Assert.IsNotNull(w3schools.NavigationtoCouponsPage());
        }

        [AfterScenario]
        public void closeBrowser()
        {
            w3schools.CloseBrowser();
        }
    }
}


