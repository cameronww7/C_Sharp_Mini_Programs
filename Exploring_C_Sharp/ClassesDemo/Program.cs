using System;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes Demo!");

            Animal dog = new Animal();
            dog.move();
            dog.makeNoise();
        }
    }
}
