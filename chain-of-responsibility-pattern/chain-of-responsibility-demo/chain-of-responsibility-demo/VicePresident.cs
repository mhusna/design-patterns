using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_responsibility_demo
{
    public class VicePresident : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 100 && expense.Amount <= 1000)
            {
                Console.WriteLine("Vice President handled the expense !");
            }
            else if (Successor != null)
            {
                Successor.HandleExpense(expense);
            }
        }
    }
}
