using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Buch 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            Book a = new Book("Goethe", "Faust", 300);
            Book b = new Book("jk", "Harry Potter", 10000);
            Book c = new Book("Goethe", "Faust II", 500);
            Book d = new Book("jk", "Harry Potter II ", 200);
            Book e = new Book("Fontane", "Effie Briest", 100);
            Book f = new Book("Bchiller", "Wilhem Tell", 300);
            books.Add(a);
            books.Add(b);
            books.Add(c);
            books.Add(d);
            books.Add(e);
            books.Add(f);

            
            foreach (Book book in books)
            {
                Console.WriteLine("Autor: "+ book.Autor + " Titel " + book.Title+"   "+ book.Anzahl+" Verkaufszahlen");
            }
            books.Sort();
            Console.WriteLine();
            foreach (Book book in books)
            {
                Console.WriteLine("Autor: " + book.Autor + " Titel " + book.Title + "   " + book.Anzahl + " Verkaufszahlen");
            }
        }
    }
}