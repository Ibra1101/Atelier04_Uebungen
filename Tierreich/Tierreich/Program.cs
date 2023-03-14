// See https://aka.ms/new-cusing System;
namespace Tierreich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eichhoernchen eichhoernchen1 = new Eichhoernchen(60);
            Uhu uhu1 = new Uhu(30);
            Baummarder baummarder1 = new Baummarder(50);
            Baummarder baummarder2 = new Baummarder(50);

            Console.WriteLine(eichhoernchen1.IsAlive);
            Console.WriteLine(uhu1.IsAlive);
            Console.WriteLine(eichhoernchen1.IsAlive);
     
            baummarder2.Eat(eichhoernchen1);
            Console.WriteLine(eichhoernchen1.IsAlive);
            Console.WriteLine(baummarder1.IsAlive);
            uhu1.Fliegen();
            eichhoernchen1.Eat(uhu1);
            baummarder2.Eat(eichhoernchen1);
        }
    }
}
