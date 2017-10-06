using System;

namespace FunctionsTime
{
    class Program
    {
        const int Value1 = 12;
        const int Value2 = 24;
        static void Main(string[] args)
        {
            Console.WriteLine(value: "Functions Time");

            int total = Add(Value1, Value2);
            Console.WriteLine("Total: " + total);

            int result;
            AddToOutParam(Value1, Value2, out result); // out in both place, where its used and in function
            Console.WriteLine("The answer is " + result);
        }

        static int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        static void AddToOutParam(int value1, int value2, out int result) //out int result, out means this is a reference &
        {
            result = value1 + value2;
        }
    }
}
