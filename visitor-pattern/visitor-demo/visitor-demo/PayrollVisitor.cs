using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor_demo
{
    public class PayrollVisitor : VisitorBase
    {
        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} paid {1}.", manager.Name, manager.Salary);
        }

        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} paid {1}.", worker.Name, worker.Salary);
        }
    }
}
