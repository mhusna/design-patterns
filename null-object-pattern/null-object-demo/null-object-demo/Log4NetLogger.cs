using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace null_object_demo
{
    public class Log4NetLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged by Log4Net logger !");
        }
    }
}
