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
        }

        private static void AnonymousMethodSyntax()
        {
            List<int> ints = new List<int>();
            ints.AddRange(new int[] {20, 1, 4, 8, 9, 44});

            List<int> evenNumbers = ints.FindAll(delegate(int i)
            {
                return (i % 2) == 0;
            });
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