using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //outputs 1-10
            for (int index = 1; index < 11; index++)
            {
                Console.WriteLine("Number: " + index);
            }


            string[] fruit = { "Apples", "Oranges", "Grapes" };

            //outputs the string array above
            for (int index = 0; index < fruit.Length; index++)
            {
                Console.WriteLine(fruit[index]);
            }
        }
    }
}
