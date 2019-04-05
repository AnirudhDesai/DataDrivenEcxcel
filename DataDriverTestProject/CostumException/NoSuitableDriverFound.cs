using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDriverTestProject.CostumException
{
    public class NoSuitableDriverFound : Exception
    {
        public NoSuitableDriverFound(String msg) : base(msg)
        {

        }
    }
}
