using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependency_injection_demo
{
    public class NHibernateProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with Nhibernate !");
        }
    }
}
