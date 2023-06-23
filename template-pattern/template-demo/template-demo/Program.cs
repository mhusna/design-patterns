using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ScoringAlgorithm algorithm
                ;
            Console.WriteLine("Mens");
            algorithm = new MensScoringAlgorithm();
            Console.WriteLine(algorithm.GenerateScore(10,new TimeSpan(0, 2, 34)));

            Console.WriteLine("Women");
            algorithm = new WomanScoringAlgorithm();
            Console.WriteLine(algorithm.GenerateScore(10, new TimeSpan(0, 2, 34)));

            Console.WriteLine("Children");
            algorithm = new ChildrenScoringAlgorithm();
            Console.WriteLine(algorithm.GenerateScore(10, new TimeSpan(0, 2, 34)));

            Console.ReadLine();
        }
    }
}
