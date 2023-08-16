using System;
namespace Task_5
{
	public class Calculator
	{
        

        public double DoOperation(double x,  Operation op, double y = 0)
        {
            var result = op switch
            {
                Operation.Add => x + y,
                Operation.Subtract => x - y,
                Operation.Multiply => x * y,
                Operation.Divide => Divide(x, y),
                Operation.Factorial => Factorial(x),
                Operation.Sqr => Math.Pow(x,y)
            };
            return result;
        }

        private double Divide(double x, double y)
        {
            try
            {
                return (x / y);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("На ноль делить нельзя");
                return 0;
            }
            
        }

        private double Factorial(double x)
        {
            try
            {
                if (x == 1) return 1;

                return x * Factorial(x - 1);
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine($"ВОзникло исключение {ex}");
                return 0;
            }
        }

        

    }
    public enum Operation
    {
        Add = 1,
        Subtract,
        Multiply,
        Divide,
        Factorial,
        Sqr
    }
}

