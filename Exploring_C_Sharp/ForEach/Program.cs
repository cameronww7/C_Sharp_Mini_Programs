using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Each!");

            string[] fruit = { "Apples", "Oranges", "Grapes", "Avocados" };

            foreach (var item in fruit)
            {
                Console.WriteLine(item);
            }
        }
    }
}
