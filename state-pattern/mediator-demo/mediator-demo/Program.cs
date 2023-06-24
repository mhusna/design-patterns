using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();
            Teacher mehmet = new Teacher(mediator);

            mehmet.Name = "Mehmet";
            mediator.Teacher = mehmet;

            Student deniz = new Student(mediator);
            deniz.Name = "Deniz";

            Student ali = new Student(mediator);
            ali.Name = "Ali";

            mediator.Students = new List<Student> { deniz, ali };

            mehmet.SendNewImageUrl("slide1.jpg");
            mehmet.ReceiveQuestion("is it true ?", deniz);


            Console.ReadLine();
        }
    }
}
