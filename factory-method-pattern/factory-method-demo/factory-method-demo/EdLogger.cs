using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_demo
{
    public class EdLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged by EdLogger.");
        }
    }
}
