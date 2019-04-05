using W3SchoolsProject.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3SchoolsProject.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        String GetWebsite();
    }
}
