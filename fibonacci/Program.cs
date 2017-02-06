using System;
using Fibonacci;

namespace ConsoleApplication
{
    public class Program
    {
        private static FibonacciGenerator _generator;

        public static void Main(string[] args)
        {
            _generator = new FibonacciGenerator();
            readFibonacciInput();
        }

        private static void readFibonacciInput() {
            Console.Write("Amount of Fibonnaci: ");
            var strN = Console.ReadLine();

            try
            {
                int n = Int32.Parse(strN);
                generateFibonnaci(n);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please put a valid number, error: {0}!", ex.Message);
                readFibonacciInput();
            }
        }

        private static void generateFibonnaci(int n) 
        {
            foreach (var digit in _generator.Generate(n))
            {
                Console.WriteLine(digit);
            }
            readFibonacciInput();
        }
    }
}
