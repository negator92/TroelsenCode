using System;

namespace GenericPoint
{
    public struct Point<T>
    {
        public Point(T xValue, T yValue)
        {
            XPosition = xValue;
            YPosition = yValue;
        }

        public T XPosition { get; set; }
        public T YPosition { get; set; }

        public override string ToString()
            => $"{XPosition}, {YPosition}";

        public void ResetPoint()
        {
            XPosition = default(T);
            YPosition = default(T);
        }
    }
}