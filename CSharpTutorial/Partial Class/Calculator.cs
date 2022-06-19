using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angie_CSharpTutorial.Partial_Class
{
    internal partial class CalcuOperator
    {
        public void Calculator(double x, double y)
        {
            Console.WriteLine($"Num1: {x}\t Num2: {y}");
            Console.WriteLine($"Sum: {Addition(x, y)}");
            Console.WriteLine($"Difference: {Subtract(x, y)}");
            Console.WriteLine($"Product: {Multiply(x, y)}");
        }
    }
}
