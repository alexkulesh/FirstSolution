using System;

namespace Part17Task2
{
    public class MathOperations
    {
        public static double MathOp(double x, double y, Operation op)
        {
            double result = 0;

            try
            {
                switch (op)
                {
                    case Operation.Addition:
                        result = x + y;
                        break;
                    case Operation.Subtraction:
                        result = x - y;
                        break;
                    case Operation.Multiplication:
                        result = x * y;
                        break;
                    case Operation.Division:
                        if (y == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        result = x / y;
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You trying to divide by zero");
            }

            return result;
        }
    }
}