using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditBase manager = new CreditManagerProxy();

            Console.WriteLine(manager.Calculate());
            Console.WriteLine(manager.Calculate());

            Console.ReadLine();
        }
    }
}
