using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor_demo
{
    public class OrganisationalStructure
    {
        public EmployeeBase Employee;
        public OrganisationalStructure(EmployeeBase firstEmployee)
        {
            Employee = firstEmployee;
        }

        public void Accept(VisitorBase visitor)
        {
            Employee.Accept(visitor);
        }
    }
}
