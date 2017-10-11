using System;

namespace InheritanceTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance Two!");

            Animal dog = new Animal();
            dog.Age = 2;
            dog.Color = "Black";

            Dog spot = new Dog();
            spot.move(); // takes this class from Animal Class
        }
    }
}
