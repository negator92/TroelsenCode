namespace LambdaExpressionsMultipleParams
{
    public class SimpleMath
    {
        public delegate void MathMessage(string message, int result);

        private MathMessage mathMessageDelegate;

        public void SetMathHandler(MathMessage target)
            => mathMessageDelegate = target;

        public void Add(int x, int y)
            => mathMessageDelegate.Invoke("Adding has completed!", x + y);
    }
}