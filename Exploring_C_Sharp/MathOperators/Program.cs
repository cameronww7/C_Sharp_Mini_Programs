using System;

namespace MathOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math Operators!");

            double value1 = 42;
            double value2 = 12;

            Console.WriteLine("Add: " + (value1 + value2));
            Console.WriteLine("Subtract: " + (value1 - value2));
            Console.WriteLine("Divide: " + (value1 / value2));
            Console.WriteLine("Multiply: " + (value1 * value2));
            Console.WriteLine("Remainder: " + (value1 % value2));

            value1++;
            Console.WriteLine("New value1: " + value1);

            Console.WriteLine("Value of value2 with decrementing: " + --value2);
            Console.WriteLine("New value of value2: " + value2);
        }
    }
}
