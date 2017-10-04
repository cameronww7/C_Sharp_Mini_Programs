using System;
using System.Text;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Builder!");

             //Place code here
            StringBuilder builder = new StringBuilder();
            builder.Append("Hello");

            Console.WriteLine(builder.ToString());

            builder.Append(", ")
                .Append("World")
                .Append("!");

            Console.WriteLine(builder.ToString());
        }
    }
}
