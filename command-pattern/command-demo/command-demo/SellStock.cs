using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command_demo
{
    public class SellStock : IOrder
    {
        StockManager _manager;

        public SellStock(StockManager manager)
        {
            _manager = manager;
        }

        public void Execute()
        {
            _manager.Sell();
        }
    }
}
