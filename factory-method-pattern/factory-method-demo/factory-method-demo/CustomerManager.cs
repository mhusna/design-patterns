using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_demo
{
    public class CustomerManager
    {
        ILoggerFactory _loggerFactory;

        public CustomerManager(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public void Save()
        {
            Console.WriteLine("Saved !");
            ILogger logger = _loggerFactory.CreateLogger();
            logger.Log();
        }
    }
}
