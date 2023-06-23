using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento_demo
{
    public class Book
    {
        string _title;
        string _author;
        string _isbn;
        DateTime _lastEdited;

        public string Title 
        {
            get { return _title;  }
            set 
            { 
                _title = value;
                SetLastEdited();
            } 
        }

        public string Author 
        {
            get { return _author; }
            set
            {
                _author = value;
                SetLastEdited();
            }
        }

        public string Isbn 
        {
            get { return _isbn; }
            set 
            {
                _isbn = value;
                SetLastEdited();
            }
        }

        void SetLastEdited()
        {
            _lastEdited = DateTime.UtcNow;
        }

        public Memento CreateUndo()
        {
            return new Memento(_title, _author, _isbn, _lastEdited);
        }

        public void RestoreFromUndo(Memento memento)
        {
            _title = memento.Title;
            _author = memento.Author;
            _isbn = memento.Isbn;
            _lastEdited = memento.LastEdited;
        }

        public void ShowBook()
        {
            Console.WriteLine(Isbn+" "+Title+" "+Author+" edited: "+_lastEdited);
        }
    }
}
