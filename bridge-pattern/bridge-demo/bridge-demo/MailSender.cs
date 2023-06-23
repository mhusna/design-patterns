using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_demo
{
    public class MailSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine(body.Title + " was sent via MailSender.");
        }
    }
}
