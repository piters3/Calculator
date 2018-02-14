using System;

namespace Calculator
{
    public class Total
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Nie można dzielić przez zero!!!");
            }
            else
            {
                return a / b;
            }            
        }

        public int Factorial(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }
    }
}
