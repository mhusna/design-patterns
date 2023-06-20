using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_demo
{
    public class Customer : Person
    {
        public string City { get; set; }
        public override Person Clone()
        {
            return (Person) MemberwiseClone();
        }
    }
}
