using System;

namespace SimpleConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(value: "Simple Console Input!");

            string input = Console.ReadLine();
            Console.WriteLine("You entered: " + input);
        }
    }
}
