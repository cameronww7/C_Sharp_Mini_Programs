using System;

namespace DeclaringVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Declaring Var!");

            //Place code here
            int i = 42;
            Console.WriteLine("The value is " + i);

            int meaningOfLife = new Int32(); //with new and data type will make it 0
            Console.WriteLine("The value is " + meaningOfLife);

            var implicitValue = 56L; //with L its 64bits and without 32bits
            Console.WriteLine("The value is " + implicitValue);
            Console.WriteLine("The variable's type is: " + implicitValue.GetType().ToString());

            byte byteValue = 255; //byte set to its max
            Console.WriteLine("The byte value is " + byteValue);

            byteValue++; // this makes it wrap to 0
            Console.WriteLine("The new byte value is " + byteValue);
        }
    }
}
