class Teiler5 
{
    static double[] zahlen = { 3.6, 5.4, 8.3, 1.93, 7.2, 12.55 };
    static void Main()
    {
        foreach(double i in zahlen)
        {
           Console.WriteLine(Math.Round(i/5)*5);
        }
    }

}