using DataDriverTestProject.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDriverTestProject.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        String GetWebsite();
    }
}
