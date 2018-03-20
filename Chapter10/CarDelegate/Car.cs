using System;

namespace CarDelegate
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaximumSpeed { get; set; } = 100;
        public string PetName { get; set; }

        private bool carIsDead;

        public Car() { }
        public Car(string name, int maximumSpeed, int currentSpeed)
        {
            PetName = name;
            MaximumSpeed = maximumSpeed;
            CurrentSpeed = currentSpeed;
        }

        public delegate void CarEngineHandler(string messageForCaller);
        private CarEngineHandler handlersList;
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            handlersList = methodToCall;
        }
    }
}