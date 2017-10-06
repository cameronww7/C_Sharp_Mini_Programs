using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If Else");

            string input = Console.ReadLine();

            if (input.Equals("Hello", StringComparison.OrdinalIgnoreCase)) // Case Senstive but adding extra function to ignore it
            {
                Console.WriteLine("You said hello!");
            }
            else if (input.Equals("Goodbye", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("You said goodbye!");
            }
            else
            {
                Console.WriteLine("You said something else!");
            }
        }
    }
}
