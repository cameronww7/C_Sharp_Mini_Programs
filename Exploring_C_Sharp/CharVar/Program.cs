using System;

namespace CharVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CharVar");
            //Place code here
            char c1 = 'a';
            Console.WriteLine("The value of c1 is " + c1);

            char c2 = '\u0062';
            Console.WriteLine("The value of c2 is " + c2);

            char symbol = '$';
            Console.WriteLine("Is " + symbol + " a number or letter? " + Char.IsLetterOrDigit(symbol));
        }
    }
}
