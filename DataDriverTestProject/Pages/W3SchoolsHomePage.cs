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
using DataDriverTestProject.Pages;

namespace W3SchoolsProject
{

    public class W3SchoolsHomePage
    {

        string xlpath = @"C:\Users\ee209973\Desktop\Data.xlsx";
       private readonly IWebDriver _driver;

        public W3SchoolsHomePage(IWebDriver driver)
        {

            _driver = driver;

        }
        public  IWebDriver NavigatetoW3schools()
        {
            
           return ObjectRepository.Driver;
        }
        public  LearnHtmlPage ClickLearnHtmllink()
        {

          //  _driver.FindElement(By.XPath("//*[@id='mySidenav']/div/a[1]")).Click();
            _driver.FindElement(By.XPath(ExcelClass.GetCellData(xlpath, "Sheet1", 1, 0).ToString())).Click();
            return (new LearnHtmlPage(_driver));
        }
     public bool test()
        {
            try
            {
              // _driver.FindElement(By.XPath("//*[@id='main']"));
                _driver.FindElement(By.XPath(ExcelClass.GetCellData(xlpath, "Sheet1", 1, 4).ToString()));

                return false;
            }
            catch (Exception e)
            {
                return true;
            }
        }


    }
}