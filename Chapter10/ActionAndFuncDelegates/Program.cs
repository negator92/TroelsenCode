using System;

namespace ActionAndFuncDelegates
{
    class Program
    {
        static void Main()
        {
            Func<int, int, int> funcToInt = new Func<int, int, int>(Add);
            int result = funcToInt.Invoke(20, 20);
            Console.WriteLine($"20 + 20 = {result}");
            Func<int, int, string> funcToString = SumToString;
            string sum = funcToString(10, 300);
            Console.WriteLine($"10 + 300 = {sum}");
            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action message!", ConsoleColor.Cyan, 3);
        }

        static string SumToString(int x, int y)
            => (x + y).ToString();

        static int Add(int x, int y)
            => x + y;

        static void DisplayMessage(string message, ConsoleColor textColor, int printCount)
        {
            ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = textColor;
            for (int i = 0; i < printCount; i++)
                Console.WriteLine(message);
            Console.ForegroundColor = previousColor;
        }
    }
}
