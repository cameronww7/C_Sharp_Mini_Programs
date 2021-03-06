﻿using System;
using System.Collections.Generic;
using System.Linq; // for .Sum() and .Average()
using System.Text;
using System.Threading.Tasks;

namespace SimpleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Array!");

            string[] fruit = { "Apples", "Oranges", "Grapes" };
            foreach (var item in fruit)
            {
                Console.WriteLine(item);
            }

            string[] names = new string[3];
            names[0] = "Joe";
            names[1] = "Mary";
            names[2] = "Martha";
            // names[3] = "david"; // cause error

            int[] weights = { 12, 34, 56, 12, 23 };
            int sum = weights.Sum();
            Console.WriteLine("The sum is " + sum);

            double average = weights.Average();
            Console.WriteLine("The average is " + average);

            UseArray(names);
        }

        static void UseArray(string[] values)
        {
            Console.WriteLine("Values in method: ");
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
