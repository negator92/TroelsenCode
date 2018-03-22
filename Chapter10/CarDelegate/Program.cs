using System;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carAlfaRomeo = new Car("AlfaRomeo", 100, 10);
            carAlfaRomeo.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            Console.WriteLine("Speeding up!");
            for (int i = 0; i < 9; i++)
                carAlfaRomeo.Accelerate(20);
        }

        public static void OnCarEngineEvent(string message)
        {
            Console.WriteLine($"\n{message}\n");
        }
    }
}