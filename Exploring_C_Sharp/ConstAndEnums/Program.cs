using System;

namespace ConstAndEnums
{
    class Program
    {
        public const int MeaningOfLife = 42;

        enum Flavors { DarkChocolate = 1, Vanilla, Strawberry };
        static void Main(string[] args)
        {
            Console.WriteLine("Const and Enums!");

            Console.WriteLine("This is a Const " + MeaningOfLife);

            Console.WriteLine("This is a Enum " + Flavors.Strawberry + " " + Flavors.Vanilla);

            
        }
    }
}
