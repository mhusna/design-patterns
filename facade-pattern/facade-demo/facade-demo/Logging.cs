using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade_demo
{
    public class Logging : ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged !");
        }
    }
}
