using System;

namespace SimpleDelegate
{
    public delegate int BinaryOperation(int a, int b);

    public class SimpleMathematic
    {
        public int Add(int a, int b)
            => a + b;

        public int Substract(int a, int b)
            => a - b;
    }
}