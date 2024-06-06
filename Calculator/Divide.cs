using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Divide
    {
        public static double DivideTwoNumbers(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            return a / b;
        }
    }
}
