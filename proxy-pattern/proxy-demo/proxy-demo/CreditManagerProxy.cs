using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy_demo
{
    public class CreditManagerProxy : CreditBase
    {
        CreditManager _creditManager;
        int _cachedValue;
        public override int Calculate()
        {
            if(_creditManager == null )
            {
                _creditManager = new CreditManager();
                _cachedValue = _creditManager.Calculate();
            }

            return _cachedValue;
        }
    }
}
