// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Schiffeversenken;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SpielFeld spielFeld = new SpielFeld();
            spielFeld.SetzeSenkrechtesSchiff(2, 4, 4);
            spielFeld.SetzeWagrechtesSchiff(3,6,6);
            spielFeld.schiesse(4, 4);
            spielFeld.schiesse(4, 5);   

           spielFeld.GibSpielfeldAufDieKonsoleAus();
           spielFeld.PruefeObGewonnen();
        }
    }
}