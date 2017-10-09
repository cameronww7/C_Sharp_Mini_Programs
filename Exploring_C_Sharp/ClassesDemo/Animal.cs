using System;

namespace ClassesDemo
{
    class Animal
    {
        private string type;
        private string color;
        private string height;
        private float weight;
        private int age;
        private int numOfLegs;

        public void move () {
            Console.WriteLine("moved");
        }

        public void makeNoise() {
            Console.WriteLine("Noise");
        }

    }
}