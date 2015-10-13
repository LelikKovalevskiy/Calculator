using System;

namespace Calculator
{
    public static class Calculator
    {
        public static double Calculate(char operation, double a, double b)
        {
            switch (operation)
            {
                case '+':
                    return Add(a, b);
                case '-':
                    return Subtract(a, b);
                case '*':
                    return Multiply(a, b);
                case '/':
                    return Divide(a, b);
                default:
                    throw new ArgumentException("Wrong operation");
            }
        }

        private static double Add(double a, double b)
        {
            return a + b;
        }

        private static double Subtract(double a, double b)
        {
            return Add(a, -b);
        }

        private static double Multiply(double a, double b)
        {
            return a * b;
        }

        private static double Divide(double a, double b)
        {
            if (Math.Abs(b - 0) < Double.Epsilon)
                throw new DivideByZeroException("Cannot divide by zero");
            return Multiply(a, 1 / b);
        }
    }
}