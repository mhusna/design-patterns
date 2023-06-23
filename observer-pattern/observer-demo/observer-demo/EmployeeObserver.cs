using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_demo
{
    public class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to employee: Product price changed !");
        }
    }
}
