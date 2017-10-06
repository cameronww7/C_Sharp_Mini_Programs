using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(value: "While Loop!");

            int counter = 1;
            int max = 10;

            while (counter <= max) {
                Console.WriteLine("Loop number : " + counter);
                counter++;
            }

            string welcome = "hello world";

            counter = 0;

            while( counter < welcome.Length) {
                Console.WriteLine(welcome[counter]);
                counter++;
            }

            counter = 0;

            do {
                Console.WriteLine("Loop number : " + counter);
                counter++;
            } while (counter <= max);
        }
    }
}
