using System;

namespace CalculatorApp
{
    public class SubFunction
    {
        /// <summary>
        /// Subtracts two numbers and returns the result.
        /// </summary>
        /// <param name="a">The number to be subtracted from.</param>
        /// <param name="b">The number to subtract.</param>
        /// <returns>The result of the subtraction.</returns>
        public double Subtract(double a, double b)
        {
            // Check if b is 0 and return a directly
            if (b == 0)
            {
                return a;
            }

            // Perform the subtraction and return the result
            return a - b;
        }
    }
}
