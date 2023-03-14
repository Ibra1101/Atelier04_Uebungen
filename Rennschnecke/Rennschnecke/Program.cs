// See https://aka.ms/new-console-template for more information
using Rennschnecke1;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Rennschnecke> Rennschnecke = new List<Rennschnecke>();
            Rennschnecke schnecke1 = new Rennschnecke();
            Rennschnecke.Add(schnecke1);
            Rennschnecke schnecke2 = new Rennschnecke("ibrahim",10);
            schnecke1.Krieche();
            schnecke2.Krieche();
            Console.WriteLine(schnecke1.ToString());
            Console.WriteLine(schnecke2.ToString());
            
        }
    }
}
