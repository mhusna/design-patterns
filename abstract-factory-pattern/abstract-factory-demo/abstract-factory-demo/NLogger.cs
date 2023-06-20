using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory_demo
{
    public class NLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged by NLogger.");
        }
    }
}
