using OpenQA.Selenium;
using PaytmScenariosTestningUsingSpecFlow.DataDriven;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDriverTestProject.Pages
{
    public class Run
    {
        string xlpath = @"C:\Users\ee209973\Desktop\Data.xlsx";
        private IWebDriver _driver;


        public Run(IWebDriver driver)
        {
            _driver = driver;
        }
        public void Tryityourself()
        {
          //  _driver.FindElement(By.ClassName("w3-button w3-bar-item w3-green w3-hover-white w3-hover-text-green")).Click();
        }
        public bool test()
        {
            try
            {
                _driver.FindElement(By.XPath(ExcelClass.GetCellData(xlpath, "Sheet1", 1, 3).ToString()));
                //_driver.FindElement(By.XPath("/html/body/h1"));
                return false;
            }
            catch (Exception e)
            {
                return true;
            }

        }
    }
}
