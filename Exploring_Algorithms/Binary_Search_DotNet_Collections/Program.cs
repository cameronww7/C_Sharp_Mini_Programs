using System;

namespace Binary_Search_DotNet_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary_Search_DotNet_Collections!");

            string[] dinners = {"Pasta",
                                "Apple Pie",
                                "Tuna Melt",
                                "Mushroom Omelet",
                                "Duck",
                                "Eggplant"};

            Console.WriteLine();
            Console.WriteLine("\nContent of array:");
            Console.WriteLine("------------------");
            foreach (string dinner in dinners)
            {
                Console.WriteLine(dinner);
            }

            Console.WriteLine("\nContent after Sort:");
            Console.WriteLine("------------------");
            Array.Sort(dinners);
            
            foreach (string dinner in dinners)
            {
                Console.WriteLine(dinner);
            }

            Console.WriteLine("\nBinarySearch for 'Beet Salad':");
            int index = Array.BinarySearch(dinners, "Beet Salad");
            DislpayWhere(dinners, index);

            Console.WriteLine("\nBinarySearch for 'Tuna Melt':");
            index = Array.BinarySearch(dinners, "Tuna Melt");
            DislpayWhere(dinners, index);
        }

        private static void DislpayWhere<T>(T[] xMyArray, int xIndex)
        {
            if (xIndex < 0)
            {            
                xIndex = ~xIndex;

                Console.Write("Not found. Sorts between: ");

                if (xIndex == 0)
                    Console.Write("beginning of array and ");
                else
                    Console.Write("{0} and ", xMyArray[xIndex - 1]);

                if (xIndex == xMyArray.Length)
                    Console.WriteLine("end of array.");
                else
                    Console.WriteLine("{0}.", xMyArray[xIndex]);
            }
            else
            {
                Console.WriteLine("Found at index {0}.", xIndex);
            }
        }
    }
}
