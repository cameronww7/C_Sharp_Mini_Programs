using System;

namespace StringVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringVar!");

            //Place code here
            char[] charArray = { 'h', 'e', 'l', 'l', 'o' }; // Array!!! OMG! AHH!!!
            Console.WriteLine("The value of charArray: " + charArray);

            string hello = new String(charArray); //
            Console.WriteLine("The value of hello: " + hello);

            string helloUpper = hello.ToUpper(); //Makes it all in CAPS
            Console.WriteLine("The value of helloUpper: " + helloUpper);

            string sub = hello.Substring(3, 2); // Like C++
            Console.WriteLine("The value of sub: " + sub);

            hello += " world"; // Addeds World
            Console.WriteLine("The value of hello: " + hello);
        }
    }
}
