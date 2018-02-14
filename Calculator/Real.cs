using System;

namespace Calculator
{
    public class Real
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
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

        public double Power(double x, int y)
        {
            double temp;
            if (y == 0)
                return 1;
            temp = Power(x, y / 2);
            if ((y % 2) == 0)
            {
                return temp * temp;
            }
            else
            {
                if (y > 0)
                    return x * temp * temp;
                else
                    return (temp * temp) / x;
            }
        }

        public double Root(double a)
        {
            double z = 0, result = a / 2;
            do
            {
                z = result;
                result = 0.5 * (result + a / result);
            }
            while (result != z);
            return result;
        }
    }
}
