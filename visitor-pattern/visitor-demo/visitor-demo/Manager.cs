using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor_demo
{
    public class Manager : EmployeeBase
    {
        public List<EmployeeBase> SubOrdinates { get; set; }

        public Manager()
        {
            SubOrdinates = new List<EmployeeBase>();
        }

        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);
            foreach (var employee in SubOrdinates)
            {
                employee.Accept(visitor);
            }
        }
    }
}
