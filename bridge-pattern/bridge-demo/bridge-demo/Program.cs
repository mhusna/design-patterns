using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.MessageSenderBase = new MailSender();
            
            customerManager.UpdateCustomer();

            Console.ReadLine();
        }
    }
}
