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
    public class LearnHtmlPage
    {
        string xlpath = @"C:\Users\ee209973\Desktop\Data.xlsx";
        private readonly IWebDriver _driver;

       

        public LearnHtmlPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public  Run Tryityourself()
        {
            _driver.FindElement(By.XPath(ExcelClass.GetCellData(xlpath, "Sheet1", 1, 1).ToString())).Click();
              //_driver.FindElement(By.XPath("//*[@id='main']/div[4]/a")).Click();
            return (new Run(_driver));

        }
        public  bool test()
        {
            try
            {
                _driver.FindElement(By.XPath(ExcelClass.GetCellData(xlpath, "Sheet1", 1, 2).ToString()));
               // _driver.FindElement(By.XPath("/html/body/div[5]/div"));
                return false;
            }
            catch(Exception e)
            {
                return true;
            }
            
        }
    }
}
