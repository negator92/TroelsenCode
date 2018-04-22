using System;
using System.Collections.Generic;

namespace SimpleLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Lambdas");
            TraditionalDelegateSyntax();
            AnonymousMethodSyntax();
            LambdaExpressionSyntax();
        }

        private static void LambdaExpressionSyntax()
        {
            List<int> ints = new List<int>();
            ints.AddRange(new int[] {20, 1, 4, 8, 9, 44});

            List<int> evenNumbers = ints.FindAll((i) =>
            {
                Console.WriteLine($"value of {nameof(i)} is currently: {i}");
                bool isEven = ((i % 2) == 0);
                return isEven;
            });
            
            Console.WriteLine("\nHere are your even numbers:");
            foreach(int number in evenNumbers)
                Console.Write($"{number}\t");
        }

        private static void AnonymousMethodSyntax()
        {
            List<int> ints = new List<int>();
            ints.AddRange(new int[] {20, 1, 4, 8, 9, 44});

            List<int> evenNumbers = ints.FindAll(i => (i % 2) == 0);
            Console.WriteLine("\nHere are your even numbers:");
            foreach (int number in evenNumbers)
                Console.Write($"{number}\t");
        }

        private static void TraditionalDelegateSyntax()
        {
            List<int> ints = new List<int>();
            ints.AddRange(new int[] {20, 1, 4, 8, 9, 44});

            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = ints.FindAll(callback);

            Console.WriteLine("\nHere are your even numbers:");
            foreach (int number in evenNumbers)
                Console.Write($"{number}\t");
        }

        private static bool IsEvenNumber(int obj)
            => (obj % 2) == 0;
    }
}