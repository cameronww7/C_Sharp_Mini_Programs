using System;

namespace PolymorphismTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism Two!");

            Animal dog = new Animal();
            dog.Age = 2;
            dog.Color = "Black";

            Dog spot = new Dog();
            spot.move(); // takes this class from Animal Class
            spot.makeNoise();
        }
    }
}
