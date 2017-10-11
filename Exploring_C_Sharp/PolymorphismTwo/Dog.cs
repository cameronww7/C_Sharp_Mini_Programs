using System;

namespace PolymorphismTwo
{
    class Dog : Animal
    {
        public string name;
        public string owner;

        public override void move() {
            Console.WriteLine("Running");
        }
    }
}