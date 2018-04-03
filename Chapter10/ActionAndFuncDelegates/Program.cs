using System;

namespace ActionAndFuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action message!", ConsoleColor.Cyan, 3);
        }

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
