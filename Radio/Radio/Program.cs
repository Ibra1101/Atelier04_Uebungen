using System;

namespace Radio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio r1 = new Radio();
            Radio r2 = new Radio();
            r2.Leiser(7);
            r1.An();
            r1.Lauter(15);
            r1.Leiser(7);
            r1.Frequenzwaehlen(15);

           Console.WriteLine( r1.ToString());


        }
    }
}