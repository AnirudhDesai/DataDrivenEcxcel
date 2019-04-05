using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using DataDriverTestProject.ComponentHelper;
using DataDriverTestProject.DataDriven;
using DataDriverTestProject.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDriverTestProject
{

    public class PaytmHomePagePOM
    {
        private TestContext _testcontext;
        string xlpath = @"C:\Users\ee209973\Desktop\Data.xlsx";
        public TestContext TestContext
        {
            get { return _testcontext; }
            set { _testcontext = value; }
        }

        #region Webelements
        [FindsBy(How = How.XPath, Using = XpathClass.Mobile)]
        private IWebElement Mobile;

        [FindsBy(How = How.XPath, Using = XpathClass.Electricity)]
        private IWebElement Electricity;

        [FindsBy(How = How.XPath, Using = XpathClass.DTH)]
        private IWebElement DTH;

        [FindsBy(How = How.XPath, Using = XpathClass.Metro)]
        private IWebElement Metro;

        [FindsBy(How = How.XPath, Using = XpathClass.MobileLink)]
        private IWebElement Mobilelink;

        [FindsBy(How = How.XPath, Using = XpathClass.MobileNum)]
        private IWebElement MobileNum;

        [FindsBy(How = How.XPath, Using = XpathClass.Amount)]
        private IWebElement Amount;

        [FindsBy(How = How.XPath, Using = XpathClass.ProceedToRecharge)]
        private IWebElement ProceedToRecharge;

        [FindsBy(How = How.XPath, Using = XpathClass.Navigation)]
        private IWebElement Navigation;

        #endregion
        public PaytmHomePagePOM()
        {

            PageFactory.InitElements(ObjectRepository.Driver, this);

        }


        #region Actions

        public void NavigateToPaytmHomePage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.Driver.Manage().Window.Maximize();
        }
        public void Mobilelinkclick()
        {
            Mobilelink.Click();
        }

       
        public void EnterMobileNumberandAmount()
        {
           
            MobileNum.SendKeys(ExcelClass.GetCellData(xlpath, "Sheet1", 1, 0).ToString());
            Amount.SendKeys(ExcelClass.GetCellData(xlpath, "Sheet1", 1, 1).ToString());

        }

     

        public void Proceedtorecharge()
        {
            ProceedToRecharge.Click();
        }

        #endregion
        #region XpathRetrive
        public IWebElement MobileXpath()
        {
            return ObjectRepository.Driver.FindElement(By.XPath(XpathClass.Mobile));


        }
        public IWebElement ElectricityXpath()
        {
            return ObjectRepository.Driver.FindElement(By.XPath(XpathClass.Electricity));
        }
        public IWebElement DTHXpath()
        {
            return ObjectRepository.Driver.FindElement(By.XPath(XpathClass.DTH));
        }
        public IWebElement MetroXpath()
        {
            return ObjectRepository.Driver.FindElement(By.XPath(XpathClass.Metro));
        }
        #endregion

        #region Navigation

        public IWebElement NavigationtoCouponsPage()
        {
           return ObjectRepository.Driver.FindElement(By.XPath(XpathClass.Navigation));
        }
        #endregion


        #region URl
        internal string GetPaytmRechargeURl()
        {
            return PaytmUrl.RechargeUrl;
        }

        internal string GetCurrentUrl()
        {
            return ObjectRepository.Driver.Url;
        }

        internal string GetCouponsUrl()
        {
            return PaytmUrl.CouponsUrl;
        }
        #endregion



        public void NavigationtoCouponsPagee()
        {
            Assert.IsNotNull(ObjectRepository.Driver.FindElement(By.XPath(XpathClass.Navigation)));
        }



        #region closeBrowser
        public void CloseBrowser()
        {

            ObjectRepository.Driver.Close();
            ObjectRepository.Driver.Dispose();
        }
        #endregion
    }



}

















































































    //public class PaytmHomePagePOM
    //{
    //    public IWebDriver driver = new ChromeDriver();

    //    private TestContext _testcontext;

    //    public TestContext TestContext
    //    {
    //        get { return _testcontext; }
    //        set { _testcontext = value; }
    //    }


    //    public void NavigateToHomePageOfPaytm()
    //    {
    //        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
    //        driver.Navigate().GoToUrl(PaytmUrl.homePageUrl);
    //        driver.Manage().Window.Maximize();
    //    }

    //    public void ClickOnMobileButton()
    //    {
    //        driver.FindElement(By.ClassName(XpathClass.mobileButton)).Click();

    //    }

    //    public void EnterMobileNumberAndAmount()
    //    {
    //        ExcelClass ex = new ExcelClass();
    //        ex.Actions();
    //        driver.FindElement(By.XPath(XpathClass.mobileNumber)).SendKeys(ExcelClass.MobileNumber);
    //        driver.FindElement(By.XPath(XpathClass.mobileNumber)).SendKeys(ExcelClass.Amount);
    //    }

    //    public void ClickOnProceedRechargeButton()
    //    {
    //        driver.FindElement(By.XPath(XpathClass.proceedRechargeButton)).SendKeys(Keys.Return);
    //        // int milliseconds = 1000;
    //        // System.Threading.Thread.Sleep(milliseconds);
    //    }

    //    internal string GetCurrentUrl()
    //    {
    //        return driver.Url;
    //    }

    //    internal object GetXpathOfCoupnPage()
    //    {
    //        return driver.FindElement(By.XPath(XpathClass.couponPage));
    //    }

    //    internal string GetPaytmRechargeURl()
    //    {
    //        return PaytmUrl.RechargeUrl;
    //    }

    //    internal string GetPaytmCouponsURl()
    //    {
    //        return PaytmUrl.CouponsUrl;
    //    }
    //}

