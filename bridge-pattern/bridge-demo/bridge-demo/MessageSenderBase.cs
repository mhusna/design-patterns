using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace bridge_demo
{
    public abstract class MessageSenderBase
    {
        public void Save()
        {
            Console.WriteLine("Message saved !");
        }

        public abstract void Send(Body body);
    }
}
