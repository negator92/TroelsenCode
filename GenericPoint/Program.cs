using System;

namespace GenericPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> intPoint = new Point<int>(20, 20);
            Console.WriteLine($"intPoint.ToString() = {intPoint.ToString()}");
            intPoint.ResetPoint();
            Console.WriteLine($"intPoint.ToString() = {intPoint.ToString()}\n");


            Point<double> doublePoint = new Point<double>(2.5, 8.8);
            Console.WriteLine($"doublePoint.ToString() = {doublePoint.ToString()}");
            doublePoint.ResetPoint();
            Console.WriteLine($"doublePoint.ToString() = {doublePoint.ToString()}");
        }
    }
}