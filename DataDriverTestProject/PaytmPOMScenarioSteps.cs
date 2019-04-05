using DataDriverTestProject;
using DataDriverTestProject.Settings;
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

        PaytmHomePagePOM paytmPom = new PaytmHomePagePOM();

        [Given(@"I have entered Paytm website")]
        public void GivenIHaveEnteredPaytmWebsite()
        {
            paytmPom.NavigateToPaytmHomePage();
        }


        [Given(@"I click on Mobile option")]
        public void GivenIClickOnMobileOption()
        {
            paytmPom.Mobilelinkclick();
        }

        [Given(@"also I have entered Mobile number and Amount")]
        public void GivenAlsoIHaveEnteredMobileNumberAndAmount()
        {
            paytmPom.EnterMobileNumberandAmount();
        }

        [When(@"I click on Proceed Recharge Button")]
        public void WhenIClickOnProceedRechargeButton()
        {
            paytmPom.Proceedtorecharge();
        }

        [When(@"fields like Mobile,Electricity,DTH,Metro are pesent")]
        public void WhenFieldsLikeMobileElectricityDTHMetroArePesent()
        {
           DTHlink = paytmPom.DTHXpath();
            metrolink = paytmPom.MetroXpath();
             electricitylink = paytmPom.ElectricityXpath();
            mobilelink = paytmPom.MobileXpath();

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
            Assert.AreEqual(paytmPom.GetPaytmRechargeURl(), paytmPom.GetCurrentUrl());
        }

        [Then(@"Page should Navigate to Proceed to Pay and Url should be https://paytm\.com/coupons")]
        public void ThenPageShouldNavigateToProceedToPayAndUrlShouldBeHttpsPaytm_ComCoupons()
        {
           // Assert.AreEqual(paytmPom.GetCouponsUrl(), paytmPom.GetCurrentUrl());


            // Assert.IsNotNull(paytmPom.GetXpathOfCoupnPage());
            Assert.IsNotNull(paytmPom.NavigationtoCouponsPage());
        }

        [AfterScenario]
        public void closeBrowser()
        {
            paytmPom.CloseBrowser();
        }
    }
}


