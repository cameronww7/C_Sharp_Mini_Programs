using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecptionsHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exceptions Handling!");

            string errorMessage;

            do {
                errorMessage = "n/a";

                int    numerator    = -1;
                int    denominator  = -1;
                int    result       = -1;

                Console.WriteLine("Enter the numerator");
                numerator = Int32.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Enter the denominator");
                denominator = Int32.Parse(Console.ReadLine());

                try
                {
                    result = numerator / denominator;

                    Console.WriteLine();
                    Console.WriteLine("The result is: " + result);
                }
                catch (OverflowException ofEx) // explicit exceptions first, too large of a number
                {
                    errorMessage = ofEx.Message;
                    Console.WriteLine("\n" + errorMessage);
                }
                catch (DivideByZeroException dEx) // explicit exceptions first, Divide by 0 error
                {
                    errorMessage = dEx.Message;
                    Console.WriteLine("\n" + errorMessage);
                }
                catch (Exception e) // Generic Exception
                {
                    errorMessage = e.Message;
                    Console.WriteLine("\n" + errorMessage);
                }
                finally // Place to add to close any files or what ever needs to happen after the try catch
                {
                    Console.WriteLine("");
                }

            } while(errorMessage != "n/a");   
        }
    }
}
