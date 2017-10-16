using System;

namespace Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear_Search!");
            
            int valueToBeFound = 7;
            int[] myArray = new int[] { 1, 4, 5, 7, 9, 22 };

            Console.WriteLine("Our array contains:");
            Array.ForEach(myArray, x => Console.Write(x + " "));

            Console.Write($"\n\nThe result of a linear search for {valueToBeFound} is located at: ");
            Console.WriteLine(linearSearch(myArray, valueToBeFound));
        }

        static int linearSearch(int[] xMyArray, int xSearchValue) {     
            int returnValue = -1;

            for (int index = 0; index < xMyArray.Length; index++)
            {
                if (xMyArray[index] == xSearchValue)
                {
                    returnValue = index; 
                    break;
                }
            }            
            return returnValue;
        }
    }
}