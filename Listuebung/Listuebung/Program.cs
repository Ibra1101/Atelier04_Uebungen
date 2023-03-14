using System;

namespace Listuebung
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            boxes.Add(new Box(10, 12, 5));
            boxes.Add(new Box(11, 13, 4));
            boxes.Add(new Box(12, 12, 5));
            boxes.Add(new Box(13, 1, 31));
            boxes.Add(new Box(14, 2, 31));
            boxes.Add(new Box(15, 3, 5));
            boxes.Add(new Box(16, 15, 31));
            boxes.Add(new Box(17, 13, 2));
            boxes.Add(new Box(18, 16, 4));
            boxes.Add(new Box(19, 19, 6));
            boxes.Add(new Box(20, 10, 9));

            Console.WriteLine("H --- L --- B ");

            foreach(Box box in boxes)
            {
                Console.WriteLine(box.Hoehe + "   " + box.Laenge + "   " + box.Breite);
            }
            // sortiert nach laenge!
            boxes.Sort(new BoxLengthFirst());
            // sortieren nach Hohe!
            boxes.Sort();
            Console.WriteLine();
            Console.WriteLine();
            foreach (Box box in boxes)
            {
                
                Console.WriteLine(box.Hoehe + "   " + box.Laenge + "   " + box.Breite);
            }
        }
    }
}