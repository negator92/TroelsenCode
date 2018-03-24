using System;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carAlfaRomeo = new Car("AlfaRomeo", 100, 10);
            carAlfaRomeo.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            Car.CarEngineHandler carHandler = new Car.CarEngineHandler(OnCarEngineEventNew);
            carAlfaRomeo.RegisterWithCarEngine(carHandler);
            Console.WriteLine("Speeding up!");
            for (int i = 0; i < 6; i++)
                carAlfaRomeo.Accelerate(20);
            carAlfaRomeo.UnregisterWithCarEngine(carHandler);
        }

        private static void OnCarEngineEventNew(string messageForCaller)
        {
            Console.WriteLine($"=> {messageForCaller.ToUpperInvariant()}");
        }

        public static void OnCarEngineEvent(string message)
        {
            Console.WriteLine($"-> {message}");
        }
    }
}