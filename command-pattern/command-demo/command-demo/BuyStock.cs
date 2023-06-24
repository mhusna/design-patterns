using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command_demo
{
    public class BuyStock : IOrder
    {
        StockManager _manager;

        public BuyStock(StockManager manager)
        {
            _manager = manager;
        }

        public void Execute()
        {
            _manager.Buy();
        }
    }
}
