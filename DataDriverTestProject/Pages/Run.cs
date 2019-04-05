using OpenQA.Selenium;
using PaytmScenariosTestningUsingSpecFlow.DataDriven;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDriverTestProject.Pages
{
    class Run
    {
        string xlpath = @"C:\Users\ee209973\Desktop\Data.xlsx";
        private IWebDriver _driver;


        public Run(IWebDriver driver)
        {
            _driver = driver;
        }
        public void Tryityourself()
        {
            _driver.FindElement(By.XPath(ExcelClass.GetCellData(xlpath, "Sheet1", 1, 2).ToString())).Click();


        }
    }
}
