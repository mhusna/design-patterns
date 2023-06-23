using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_responsibility_demo
{
    public class Manager : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if(expense.Amount <= 100)
            {
                Console.WriteLine("Manager handled the expense !");
            }
            else if(Successor != null)
            {
                Successor.HandleExpense(expense);
            }
        }
    }
}
