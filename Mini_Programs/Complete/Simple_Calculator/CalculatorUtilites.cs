using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class CalculatorUtilites
    {
        public static double Add(double xDouble1, double xDouble2) {
            return xDouble1 + xDouble2;
        }
        
        public static double Subtract(double xDouble1, double xDouble2) {
            return xDouble1 - xDouble2;
        }
        
        public static  double Divide(double xDouble1, double xDouble2) {
            if (xDouble1 == 0 || xDouble2 == 0) {
                return 0;
            } else {
                return xDouble1 / xDouble2;
            }
        }
        
        public static double Multiply(double xDouble1, double xDouble2) {
            return xDouble1 * xDouble2;
        }
    }
}
