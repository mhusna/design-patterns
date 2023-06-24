using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator_demo
{
    public class Teacher : CourseMember
    {
        public string Name { get; set; }
        public Teacher(Mediator mediator) : base(mediator)
        {
        }

        public void ReceiveQuestion(string question, Student student)
        {
            Console.WriteLine("Teacher received a question: "+question+" from: "+student.Name);
        }

        public void SendNewImageUrl(string url)
        {
            Console.WriteLine("Teacher changed slide: "+url);
            Mediator.UpdateImage(url);
        }

        public void AnswerQuestion(string question, Student student)
        {
            Console.WriteLine("Teacher answered question: "+student.Name+" "+question);
        }
    }
}
