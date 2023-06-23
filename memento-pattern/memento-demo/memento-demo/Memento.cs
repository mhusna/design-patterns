using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento_demo
{
    public class Memento
    {
        public string  Title { get; set; }
        public string  Author { get; set; }
        public string  Isbn { get; set; }
        public DateTime LastEdited { get; set; }

        public Memento(string title, string author, string isbn, DateTime lastEdited)
        {
            Title = title;
            Isbn = isbn;
            Author = author;
            LastEdited = lastEdited;
        }
    }
}
