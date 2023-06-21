using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade_demo
{
    public class Caching:ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached !");
        }
    }
}
