using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.CreditCalculatorBase = new Before2010CreditCalculator();
            customerManager.SaveCredit();

            Console.ReadLine();
        }
    }
}
