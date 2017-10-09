using System;

namespace ClassesDemo
{
    class Animal
    {
        private string type;
        private string color;
        private float height;
        private float weight;
        private int age;
        private int numOfLegs;


        public string Type {
            get { return this.type; }
            set { this.type = value; }
        }


        public string Color {
            get { return this.color; }
            set { this.color = value; }
        }


        public float Height {
            get { return this.height; }
            set { this.height = value; }
        }

        public float Weight {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public int Age {
            get { return this.age; }
            set { 
                    if(value < 0) {
                        Console.WriteLine("Age cannot be less than 0");
                    } else {
                        this.age = value;
                    } 
                }
        }

        public int NumOfLegs {
            get { return this.numOfLegs; }
            set { this.numOfLegs = value; }
        }


        public void move () {
            Console.WriteLine("moved");
        }

        public void makeNoise() {
            Console.WriteLine("Noise");
        }

    }
}