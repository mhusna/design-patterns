using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy_demo
{
    public class CustomerManager
    {
        public CreditCalculatorBase CreditCalculatorBase { get; set; }


        public void SaveCredit()
        {
            Console.WriteLine("Customer manager business.");
            CreditCalculatorBase.Calculate();
        }
    }
}
