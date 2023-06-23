using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            ModifiedState modifiedState = new ModifiedState();
            modifiedState.DoAction(context);

            DeletedState deletedState = new DeletedState();
            deletedState.DoAction(context);

            Console.WriteLine(context.GetState().ToString());
            Console.ReadLine();
        }
    }
}
