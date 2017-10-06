using System;
using System.Collections.Generic;
using System.Linq;

namespace POCOclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var produce = new List<object>();

            var f1 = new Fruit(); // No constructor, combiler will create no arg one
            produce.Add(f1);

            var f2 = new Fruit(); // No constructor, combiler will create no arg one
            produce.Add(f2);

            produce.Add(new Vegetable()); // addes a new with the () makes a new redefualt

            Console.WriteLine("There are " + produce.Count + " items");

            foreach (var item in produce)
            {
                Console.WriteLine(item);
            }

        }

    }

    class Fruit
    {

    }

    class Vegetable
    {

    }
}
