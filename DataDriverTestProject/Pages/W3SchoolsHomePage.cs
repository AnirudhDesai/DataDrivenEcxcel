using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using W3SchoolsProject.ComponentHelper;
using W3SchoolsProject.DataDriven;
using W3SchoolsProject.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3SchoolsProject
{

    public class W3SchoolsHomePage
    {

        string xlpath = @"C:\Users\ee209973\Desktop\Data.xlsx";
        static IWebDriver _driver;

        public W3SchoolsHomePage()
        {
         


        }




        public static void NavigatetoW3schools()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());

            ObjectRepository.Driver.Manage().Window.Maximize();
            _driver = ObjectRepository.Driver;
        }
        public IWebDriver ClickLearnHtmllink()
        {

            _driver.FindElement(By.XPath("//*[@id='mySidenav']/div/a[1]")).Click();

            return _driver;


        }


    }
}