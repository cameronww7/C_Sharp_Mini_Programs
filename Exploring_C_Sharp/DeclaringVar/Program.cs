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

            int meaningOfLife = new Int32();
            Console.WriteLine("The value is " + meaningOfLife);

            var implicitValue = 56L;
            Console.WriteLine("The value is " + implicitValue);
            Console.WriteLine("The variable's type is: " + implicitValue.GetType().ToString());

            byte byteValue = 255;
            Console.WriteLine("The byte value is " + byteValue);

            byteValue++;
            Console.WriteLine("The new byte value is " + byteValue);
        }
    }
}
