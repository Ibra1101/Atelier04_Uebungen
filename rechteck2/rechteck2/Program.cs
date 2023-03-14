using rechteck_prop;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Rechteck r1 = new Rechteck();
            Rechteck r2 = new Rechteck(3, 6);

            Console.WriteLine(r1.laenge);
            Console.WriteLine(r2.laenge);
        }
    }
}