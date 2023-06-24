using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace null_object_demo
{
    public class NLogLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged by NLog logger !");
        }
    }
}
