using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_demo
{
    public class LoggerFactory:ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            //Business to decide factory.
            return new EdLogger();
        }
    }
}
