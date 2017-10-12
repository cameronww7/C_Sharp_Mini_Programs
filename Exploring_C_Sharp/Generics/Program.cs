using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics!");

            Stack myStack = new Stack();

            myStack.Push("A String");
            myStack.Push(42);
            myStack.Push(myStack);

            myStack.Pop();

            Stack<string> strString = new Stack<string>(); // self documentation

            strString.Push("A string");
            // strString.Push(42); // will error, expects a string

        }
    }
}
