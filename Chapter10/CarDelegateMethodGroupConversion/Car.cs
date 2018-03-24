using System;

namespace CarDelegateMethodGroupConversion
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
            // handlersList += methodToCall;
            if (handlersList == null)
                handlersList = methodToCall;
            else
                Delegate.Combine(handlersList, methodToCall);
        }

        public void UnregisterWithCarEngine(CarEngineHandler methodToCall)
        {
            handlersList -= methodToCall;
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (handlersList != null)
                    handlersList("Sorry, car is broken.");
            }
            else
            {
                CurrentSpeed += delta;
                if (10 == (MaximumSpeed - CurrentSpeed) && handlersList != null)
                    handlersList("Attention, be careful. Car looks dying.");
                if (CurrentSpeed >= MaximumSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine($"Current speed is {CurrentSpeed}.");
            }
        }
    }
}