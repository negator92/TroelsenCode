using System;

namespace GenericPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> intPoint = new Point<int>(20, 20);

            Point<double> doublePoint = new Point<double>(2.0, 0.2);
        }
    }
}