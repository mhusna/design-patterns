using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade_demo
{
    public class CustomerManager
    {
        CrossCuttingConcernsFacade _concern;
        public CustomerManager()
        {
            _concern = new CrossCuttingConcernsFacade();

        }

        public void Save()
        {
            _concern.Logging.Log();
            _concern.Authorize.CheckUser();
            _concern.Caching.Cache();

            Console.WriteLine("Saved !");
        }
    }
}
