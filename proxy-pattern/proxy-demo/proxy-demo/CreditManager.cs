using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace proxy_demo
{
    public class CreditManager : CreditBase
    {
        public override int Calculate()
        {
            int result = 1;

            for(int i = 1; i < 5; i++)
            {
                result *= i;
                Thread.Sleep(1000);
            }

            return result;
        }
    }
}
