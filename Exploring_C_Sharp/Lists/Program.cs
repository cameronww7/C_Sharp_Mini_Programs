using System;
using System.Collections.Generic; // for List
using System.Linq; // for .Contains

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lists!");

            var fruitList = new List<string>();

            fruitList.Add("Apple");
            fruitList.Add("Orange");
            fruitList.Add("Fig");

            foreach (var item in fruitList)
            {
                Console.WriteLine(item);
            }

            fruitList.Sort();
            foreach (var item in fruitList)
            {
                Console.WriteLine(item);
            }

            ReportOnFigs(fruitList);

        }

        static void ReportOnFigs(List<string> items)
        {
            string figReport =
                items.Contains("Fig", StringComparer.OrdinalIgnoreCase) ?
                "Yes there are figs." :
                "No there are no figs";
            Console.WriteLine(figReport);
        }
    }
}
