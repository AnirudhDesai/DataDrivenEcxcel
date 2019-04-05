using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3SchoolsProject.CostumException
{
    public class NoSuitableDriverFound : Exception
    {
        public NoSuitableDriverFound(String msg) : base(msg)
        {

        }
    }
}
