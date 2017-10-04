using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dates and Times!");

            DateTime dt = new DateTime(2014, 1, 1);
            Console.WriteLine("The date is " + dt.ToString("MMMM d, yyyy"));

            DateTime now = DateTime.Now;
            Console.WriteLine("Now is " + now.ToString("MMMM d, yyyy"));

            DateTime anotherDay = dt.AddDays(-1);
            Console.WriteLine("The date is " + anotherDay.ToString("MMMM d, yyyy"));
        }
    }
}
