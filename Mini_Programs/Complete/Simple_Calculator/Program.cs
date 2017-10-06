using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator!");

                        //Get values to calculate
            double double1 = GetValue("Enter value 1: ");
            double double2 = GetValue("Enter value 2: ");

            //Declare variable to hold result
            double result = 0;

            //Do math operation
            while (true)
            {
                Console.Write("(A)dd (S)ubtract (M)ultiply (D)ivide : ");
                
                ConsoleKeyInfo info = Console.ReadKey(); //reads one char
                string operation = info.Key.ToString();

                switch (operation.ToUpper()) {
                    case "A" :
                        result = CalculatorUtilites.Add(double1, double2);
                        break;
                    case "S":
                        result = CalculatorUtilites.Subtract(double1, double2);
                        break;
                    case "M":
                        result = CalculatorUtilites.Multiply(double1, double2);
                        break;
                    case "D":
                        result = CalculatorUtilites.Divide(double1, double2);
                        break;
                    default :
                        Console.WriteLine("Choose from supported operations");
                        continue;
                }
                Console.WriteLine("\nResult: " + result);
                break;
            }

            double GetValue(string xUserPrompt) {
                double returnVal = 0;

                Console.WriteLine(xUserPrompt);
                string input = Console.ReadLine();

                if (Double.TryParse(input, out returnVal)) {
                    return returnVal;
                } else {
                    Console.WriteLine("Value can't be parsed as a number");
                }

                return returnVal;
            }
        }
    }
}
