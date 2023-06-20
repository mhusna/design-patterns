using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Mehmet Husna",
                LastName = "Kisla",
                City = "İstanbul"
            };
            Console.WriteLine(customer1.FirstName);

            Customer customer2 = (Customer)customer1.Clone();
            customer2.FirstName = "Ahmet";

            Console.WriteLine("Customer 1: "+customer1.FirstName +" "+ customer1.LastName);
            Console.WriteLine("Customer 2: " + customer2.FirstName +" "+ customer2.LastName);

            Console.ReadLine();
        }
    }
}
