using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exceptions!");

            try {
                string[] fruit = { "Apples", "Oranges", "Grapes" };
                for (int i = 0; i <= fruit.Length; i++) {               
                    // Debug.WriteLine("Value of i : " + i); // use Debug function to get more information!!!
                    Console.WriteLine(fruit[i]);
                }
            // } catch (Exception ex) { // the master of exceptions if u dont know the execption that will be thrown
            } catch (IndexOutOfRangeException ex) {
                Console.WriteLine("Index problem!!");
                Console.WriteLine(ex.Message);                
            } catch (ArgumentNullException ex) {
                Console.WriteLine("Null problem!");
                Console.WriteLine(ex.Message);
            } finally { // finally always is excuted at the end of the try and catch
                Console.WriteLine("Finally block has been reached!");
            }
        }
    }
}
