using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Switch Statement");

            Console.Write("Enter an operation: + - * / ");
            string operation = Console.ReadLine();

            // just like c++
            switch (operation)
            {
                case "+" :
                    Console.WriteLine("You chose to add");
                    break;

                case "-":
                    Console.WriteLine("You chose to subtract");
                    break;

                case "*":
                    Console.WriteLine("You chose to multiply");
                    break;

                case "/":
                    Console.WriteLine("You chose to divide");
                    break;

                default:
                    Console.WriteLine("No such operation");
                    break;
            }
        }
    }
}
