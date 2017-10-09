using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Types!");

            //Concatenate("First ", "Last");
            string word = Concatenate("First ", "Last");
            Console.WriteLine(Concatenate("First ", "Last"));

            #region Data Types
            // numeric data types
            sbyte   aSignedByte     = 127;
            byte    aByte           = 255;
            ushort  anUnsignedShort = 65535;
            short   aShort          = 32767;
            int     anInt           = 2147483647;
            uint    anUnsignedInt   = 4294967295;
            ulong   anUnsignedLong  = 18446744073709551615;
            long    aLong           = 9223372036854775807;
            float   aFloat          = 105.5678493F;
            double  aDouble         = 105.567849312873245;
            decimal aDecimal        = 105.84923797593487492387492374982347987293487M;

            // character data types
            char   aChar   = 'A';
            string aString = "A string of chars";

            // Boolean Types
            bool trueResult  = true;
            bool falseResult = false;


            //Output values, .NET types, size of data type and max value
            Console.WriteLine("aByte    value is {0}, {1}, {2} Byte(s), {3}", aByte, typeof(byte), sizeof(byte), byte.MaxValue);
            Console.WriteLine("anInt    value is {0}, {1}, {2} Byte(s), {3}", anInt, typeof(int), sizeof(int), int.MaxValue);
            Console.WriteLine("aLong    value is {0}, {1}, {2} Byte(s), {3}", aLong, typeof(long), sizeof(long), long.MaxValue);
            Console.WriteLine("aFloat   value is {0}, {1}, {2} Byte(s), {3}", aFloat, typeof(float), sizeof(float), float.MaxValue);
            Console.WriteLine("aDouble  value is {0}, {1}, {2} Byte(s), {3}", aFloat, typeof(double), sizeof(double), double.MaxValue);
            Console.WriteLine("aDecimal value is {0}, {1}, {2} Byte(s), {3}", aDecimal, typeof(decimal), sizeof(decimal), decimal.MaxValue);

            #endregion

            #region Loops

            // for loop 
            for(int counter = 0; counter < 10; counter++)
            {
               Console.WriteLine(counter);
            }


            // foreach loop

            int[] arrInts = new int[] { 3, 5, 6, 23, 95, 45, 32 };
            foreach (int item in arrInts)
            {
               Console.WriteLine(item);
            }


            // while loop 
            int sentinel = 0;
            while (sentinel < 10)
            {
               Console.WriteLine(sentinel);
               sentinel++;
            }


            // do while loop 
            int exitVar = 10;
            do
            {
               Console.WriteLine(exitVar);
               exitVar++;
            } while (exitVar < 10);

            #endregion

            #region Decision Structures
            // if statement
            bool result = falseResult;
            if (1 == 1)
            {
               Console.WriteLine("Result was " + trueResult + " (true)");
            }
            else
            {
               Console.WriteLine("Result was " + falseResult + " (true)");
            }


            // if..else if
            int value = 2;
            if (value == 0)
            {
               Console.WriteLine("Value is 0");
            }
            else if (value == 1)
            {
               Console.WriteLine("Value is not 0");
            }
            else
            {
               Console.WriteLine("Value is something else");
            }


            // switch statment
            int value2 = 1;

            switch (value2)
            {
               case 0:
                   Console.WriteLine("Value is 0");
                   break;

               case 1:
                   Console.WriteLine("Value is 1");
                   break;

               default:
                   Console.WriteLine("Value is something else");
                   break;
            }
            #endregion
        }

        // Create a non-returning function here that concatenates two strings and just displays the result in screen
        // static void Concatenate(string first, string last)
        // {
        //    string whole = first + last;
        //    Console.WriteLine(whole);
        // }



        // Create a returning function here that concatenates two strings and returns the result
        static string Concatenate(string first, string last)
        {
            string whole = first + last;
            return whole;
        }

    }
}
