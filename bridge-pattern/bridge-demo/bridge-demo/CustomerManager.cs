using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_demo
{
    public class CustomerManager
    {
        public MessageSenderBase MessageSenderBase { get; set; }
        public void UpdateCustomer()
        {
            MessageSenderBase.Send(new Body
            {
                Title = "About the course."
            });
            Console.WriteLine("Customer updated !");
        }
    }
}
