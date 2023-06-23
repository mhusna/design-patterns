using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var personalCar = new PersonalCar
            {
                Make = "BMW",
                Model = "3.20",
                HirePrice = 2500
            };

            SpecialOffer specialOffer = new SpecialOffer(personalCar);
            specialOffer.DiscountPercentage = 10;

            Console.WriteLine("Concrete: "+personalCar.HirePrice);
            Console.WriteLine("Special offer: "+specialOffer.HirePrice);

            Console.ReadLine();
        }
    }
}
