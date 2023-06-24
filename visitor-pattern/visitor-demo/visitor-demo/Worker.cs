using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor_demo
{
    public class Worker : EmployeeBase
    {
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }
}
