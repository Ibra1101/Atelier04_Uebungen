using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buch
{
    public class Book :IComparable<Book>
    {
        public string Autor { get; private set;}
        public string Title { get; private set;}
        public int Anzahl {get; private set;}

        public Book(string autor, string title, int anzahl)
        {
            Autor = autor;
            Title = title;
            Anzahl = anzahl;
        }

        public int CompareTo(Book o)
        {
            if (o == null) return -1;

            int i = this.Autor.CompareTo(o.Autor);
            if (i!=0)
            {
                return i;
            }
            else
            {
                i = this.Title.CompareTo(o.Title);
                if (i!=0)
                {
                    return i;
                }
                else
                {
                    i = this.Anzahl - o.Anzahl;
                    return i;
                }

                
            }

           
            
        }
    }
}
