using System;
using System.Collections.Generic;

namespace Linear_Search_DotNet_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear_Search_DotNet_Collections!");

            List<string> listOfActors = new List<string>();

            listOfActors.Add("Tom Cruise");
            listOfActors.Add("Madonna");
            listOfActors.Add("Bruce Lee");
            listOfActors.Add("Jimmy Fallon");

            Console.WriteLine("Linear search results: \n\nIn the collection, there are {0} actors:", listOfActors.Count);
            PrintOut(listOfActors);

            Console.WriteLine("\nOf which, the IndexOf(\"Madonna\") is located at {0}", listOfActors.IndexOf("Madonna"));

        }

        private static void PrintOut(List<string> xList)
        {
            Console.WriteLine();
            foreach (string item in xList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
