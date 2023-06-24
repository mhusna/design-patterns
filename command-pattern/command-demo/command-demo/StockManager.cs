using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command_demo
{
    public class StockManager
    {
        string _name = "Laptop";
        int _quantity = 10;

        public void Buy()
        {
            Console.WriteLine("Stock: {0}, {1} bought !",_name,_quantity);
        }
        public void Sell()
        {
            Console.WriteLine("Stock: {0}, {1} sold !", _name, _quantity);
        }
    }
}
