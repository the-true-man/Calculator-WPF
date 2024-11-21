using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    public class Calc2
    {

        public static double div(double a, double b)
        {
            if(b == 0) return 0;
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
