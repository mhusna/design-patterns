using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator_demo
{
    public class Student : CourseMember
    {
        public string Name { get; set; }

        public Student(Mediator mediator) : base(mediator)
        {
        }

        public void ReceiveAnswer(string answer)
        {
            Console.WriteLine(Name+" received answer: "+answer);
        }

        public void RecieveImage(string url)
        {
            Console.WriteLine(Name+" received image: " +url);
        }
    }
}
