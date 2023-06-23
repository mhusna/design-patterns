using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee ahmet = new Employee { Name = "Ahmet Gezer"};

            Employee mehmet = new Employee { Name = "Mehmet Gezer"};
            Employee cevdet = new Employee { Name = "Cevdet Gezer" };

            Employee selim = new Employee { Name = "Selim Başar" };

            Contractor ali = new Contractor { Name = "Ali Sezer" };

            ahmet.AddSubordinate(mehmet);
            ahmet.AddSubordinate(cevdet);

            mehmet.AddSubordinate(selim);
            mehmet.AddSubordinate(ali);

            Console.WriteLine(ahmet.Name);
            foreach (Employee manager in ahmet) {
                
                Console.WriteLine("  "+manager.Name);

                foreach (IPerson employee in manager)
                {
                    Console.WriteLine("    "+employee.Name);
                }
            }

            Console.ReadLine();
        }
    }
}
