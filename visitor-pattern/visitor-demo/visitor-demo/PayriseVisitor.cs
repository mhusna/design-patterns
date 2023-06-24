using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor_demo
{
    public class PayriseVisitor : VisitorBase
    {
        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} salary increased to {1}.", manager.Name, manager.Salary * (decimal)1.2);
        }

        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} salary increased to {1}.", worker.Name, worker.Salary * (decimal)1.1);
        }
    }
}
