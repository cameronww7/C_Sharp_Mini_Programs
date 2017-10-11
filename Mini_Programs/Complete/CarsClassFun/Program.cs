using System;

namespace CarsClassFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cars Class Fun!");

            Car myCar = new Car();
            myCar.Make = "Scion";
            myCar.Model = "XB";
            myCar.Color = "White";

            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Color);

            myCar.Drive();
            myCar.Stopping();
        }
    }
}
