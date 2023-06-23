using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator_demo
{
    public class SpecialOffer : CarDecoratorBase
    {
        public int DiscountPercentage { get; set; }
        CarBase _carBase;
        public SpecialOffer(CarBase carBase) : base(carBase)
        {
            _carBase = carBase;
        }

        public override string Make { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice { 
            get { return _carBase.HirePrice - (_carBase.HirePrice * DiscountPercentage/100); } 
            set
            {
            }
        }
    }
}
