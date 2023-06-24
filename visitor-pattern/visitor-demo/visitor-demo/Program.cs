using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager ahmet = new Manager { Name = "Ahmet", Salary = 1100 };
            Manager mehmet = new Manager { Name="Mehmet", Salary=1000};

            Worker batuhan = new Worker { Name="Batuhan", Salary=750};
            Worker saruhan = new Worker { Name= "Saruhan", Salary=750};

            ahmet.SubOrdinates.Add(mehmet);
            mehmet.SubOrdinates.Add(batuhan);
            mehmet.SubOrdinates.Add(saruhan);

            OrganisationalStructure structure = new OrganisationalStructure(ahmet);

            PayrollVisitor payrollVisitor = new PayrollVisitor();
            PayriseVisitor payriseVisitor = new PayriseVisitor();

            structure.Accept(payrollVisitor);
            Console.WriteLine("*****************");
            structure.Accept(payriseVisitor);

            Console.ReadLine();
        }
    }
}
