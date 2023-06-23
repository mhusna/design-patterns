using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            var customerObserver = new CustomerObserver();

            productManager.Attach(customerObserver);
            productManager.Attach(new EmployeeObserver());
            productManager.Detach(customerObserver);
            productManager.UpdatePrice();

            Console.ReadLine();
        }
    }
}
