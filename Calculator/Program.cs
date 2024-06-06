using System;

namespace CalculatorApp
{
    // Calculator class containing methods for basic arithmetic operations
    public class Calculator
    {
        public double Add(double a, double b) => a + b;

        public double Subtract(double a, double b) => a - b;

        public double Multiply(double a, double b) => a * b;

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }
    }

    // ExceptionHandling class to handle exceptions
    public static class ExceptionHandling
    {
        public static void HandleException(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine("Please try again.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            try
            {
                double num1 = ReadDoubleInput("Enter the first number:");
                double num2 = ReadDoubleInput("Enter the second number:");
                string operation = ReadOperation();

                double result = PerformCalculation(calculator, num1, num2, operation);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                ExceptionHandling.HandleException(ex);
            }
        }

        static double ReadDoubleInput(string prompt)
        {
            double number;
            Console.WriteLine(prompt);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }
            return number;
        }

        static string ReadOperation()
        {
            Console.WriteLine("Choose an operation (+, -, *, /):");
            string operation = Console.ReadLine();
            while (operation != "+" && operation != "-" && operation != "*" && operation != "/")
            {
                Console.WriteLine("Invalid operation. Please choose a valid operation (+, -, *, /):");
                operation = Console.ReadLine();
            }
            return operation;
        }

        static double PerformCalculation(Calculator calculator, double num1, double num2, string operation)
        {
            return operation switch
            {
                "+" => calculator.Add(num1, num2),
                "-" => calculator.Subtract(num1, num2),
                "*" => calculator.Multiply(num1, num2),
                "/" => calculator.Divide(num1, num2),
                _ => throw new InvalidOperationException("Invalid operation.") // This should never happen due to validation
            };
        }
    }
}
