using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PaytmScenariosTestningUsingSpecFlow.DataDriven;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDriverTestProject.Pages
{
    class LearnHtmlPage
    {
        string xlpath = @"C:\Users\ee209973\Desktop\Data.xlsx";
        private IWebDriver _driver;
       

        public LearnHtmlPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebDriver Tryityourself()
        {
          //  _driver.FindElement(By.XPath(ExcelClass.GetCellData(xlpath, "Sheet1", 1, 1).ToString())).Click();
            _driver.FindElement(By.XPath("//*[@id='main']/div[4]/a")).Click();
            return _driver;

        }
    }
}
