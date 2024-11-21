using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    public  class Calculator
    {

        public static double Sum(double a, double b)
        {
            return a + b;
        }
        public static double Minus(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            if(b == 0)
            {
                return 0;
            }
            return a / b;
        }

        public static double Equally(double a)
        {
            return a;
        }

        public static double Clear()
        {
            return 0;
        }
    }
}
