using System;

namespace Triangle // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 10; i >= 0; i--)
            {
               for(int j = i; j >=0; j--)
                {
                    Console.Write( j + " ");
                }
               Console.WriteLine();
            }
        }
    }
}