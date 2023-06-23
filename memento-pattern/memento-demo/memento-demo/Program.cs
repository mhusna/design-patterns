using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book
            {
                Isbn = "12345",
                Title = "Sefiller",
                Author = "Victor Hugo",
            };
            book.ShowBook();
            
            CareTaker history = new CareTaker();
            history.Memento = book.CreateUndo();

            book.Isbn = "54321";
            book.Title = "VICTOR HUGO";
            book.ShowBook();

            book.RestoreFromUndo(history.Memento);
            book.ShowBook();

            Console.ReadLine();
        }
    }
}
