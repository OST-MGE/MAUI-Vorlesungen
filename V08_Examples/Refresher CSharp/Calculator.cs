namespace Refresher_CSharp
{
    public static class Calculator
    {
        public delegate int Calculation(int a, int b);

        public static int Add(int a, int b) => a + b;

        public static int Multiply(int a, int b) => a * b;
    }
}
