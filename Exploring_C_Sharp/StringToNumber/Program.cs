using System;

namespace StringToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String to Number!");

            //Place code here
            string s = "255";
            int intFromString = Int32.Parse(s);
            Console.WriteLine("Value of intFromString: " + intFromString);

            int doubled = intFromString * 2;
            Console.WriteLine("Value of doubled: " + doubled);

            string s2 = "19.99";
            //double doubleFromString = Double.Parse(s2);
            //Output("Value of doubleFromString: " + doubleFromString);

            double doubleFromString;
            if (Double.TryParse(s2, out doubleFromString))
            {
                Console.WriteLine("Value of doubleFromString: " + doubleFromString);
            }
            else
            {
                Console.WriteLine("Couldn't parse the value!");
            }
        }
    }
}
