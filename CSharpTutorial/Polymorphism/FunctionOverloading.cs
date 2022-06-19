using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePartialClass.Polymorphism
{
    internal class FunctionOverloading
    {
        public static void DisplayOutput(string name, int age)
        {
            Console.WriteLine("string + int: {0} {1}", name, age);
        }
        public static void DisplayOutput(int num1, int num2)
        {
            Console.WriteLine("int + int: {0} {1}", num1, num2);
        }
        public static void DisplayOutput(double num1, int num2)
        {
            Console.WriteLine("double + int: {0} {1}", num1, num2);
        }


    }
}
