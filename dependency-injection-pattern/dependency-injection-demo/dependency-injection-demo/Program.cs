using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace dependency_injection_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            ProductManager manager = new ProductManager(kernel.Get<IProductDal>());
            manager.Save();

            Console.ReadLine();
        }
    }
}
