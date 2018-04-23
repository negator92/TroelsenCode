using System;

namespace LambdaExpressionsMultipleParams
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath math = new SimpleMath();
            math.SetMathHandler((message, result) =>
                {
                    Console.WriteLine($"Message: {message}, result: {result}");
                });
            math.Add(10, 10);
        }
    }
}