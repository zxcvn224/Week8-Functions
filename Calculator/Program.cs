using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AddTwoNumbers(20, 6);
            DivideTwoNumbers(20, 6);
        }

        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }

        private static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine($"{x} + {y} = {result}");
        }
    }
}
