using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state_demo
{
    public class DeletedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State deleted !");
            context.SetState(this);
        }

        public override string ToString()
        {
            return "Deleted State !";
        }
    }
}
