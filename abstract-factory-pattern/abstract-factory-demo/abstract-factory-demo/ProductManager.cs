using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory_demo
{
    public class ProductManager
    {
        CrossCuttingConcernsFactory _crossCuttingConcernsFactory;

        Logging _logging;
        Caching _caching;

        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _crossCuttingConcernsFactory = crossCuttingConcernsFactory;
            _logging = _crossCuttingConcernsFactory.CreateLogger();
            _caching = _crossCuttingConcernsFactory.CreateCaching();
        }

        public void GetAll() 
        {
            _logging.Log("Logged");
            _caching.Cache("Data");
            Console.WriteLine("Products listed !");
        }
    }
}
