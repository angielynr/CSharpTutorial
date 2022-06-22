using System;

namespace Delegates.Demo
{
    internal class Program
    {
        delegate int MathOp(int x, int y);
        static void Main(string[] args)
        {
            MathOp operation = new MathOp(Add);

            //DisplayValue(operation(3, 5));

            CalculateAndPrint(6, 5, Add);
            CalculateAndPrint(6, 5, Subtract);
            CalculateAndPrint(6, 5, Divide);
            CalculateAndPrint(6, 2, Multiply);

            CalculateAndPrint(6, 9, delegate (int x, int y) { return x + y; });
            CalculateAndPrint(11, 22, (x, y) => { return x + y; });
            CalculateAndPrint(33, 22, (x, y) => { return x - y; });
            Console.ReadLine();

        }

        static void CalculateAndPrint(int x, int y, MathOp oper)
        {
            DisplayValue(oper(x, y));
        }
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }
        private static void DisplayValue(int display)
        {

            Console.WriteLine($"value: {display}");
        }
    }
}
