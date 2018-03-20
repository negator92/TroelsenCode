using System;

namespace SimpleDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMathematic simpleMathematic = new SimpleMathematic();
            BinaryOperation binaryOperation = new BinaryOperation(simpleMathematic.Add);
            Console.WriteLine($"88 + 88 = {binaryOperation(88, 88)}");
            // Console.WriteLine($"88 + 88 = {SimpleMathematic.Add(88, 88)}");

            DisplayDelegateInfo(binaryOperation);

            // binaryOperation = new BinaryOperation(SimpleMathematic.Substract);
            // Console.WriteLine($"88 + 88 = {binaryOperation(88, 88)}");
            // Console.WriteLine($"88 + 88 = {SimpleMathematic.Substract(88, 88)}");

            // DisplayDelegateInfo(binaryOperation);
        }

        static void DisplayDelegateInfo(Delegate delegateObject)
        {
            foreach (Delegate eachDelegate in delegateObject.GetInvocationList())
            {
                Console.WriteLine($"Method name: {eachDelegate.Method}");
                Console.WriteLine($"Type name: {eachDelegate.Target}");
            }
        }
    }
}