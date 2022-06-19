using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysVariableParameter
{
    internal class VaryingArguments
    {
        public static void VaryingArguments1()
        {
            DisplayItems("Hello", 1, 2, 3, 5);

            int[] anArray = new int[5] { 100, 200, 300, 400, 500 };

            DisplayItems("Hello", anArray);
            DisplayItems("Hello", 1500, 3000, anArray[1] * anArray[2]);
        }

        private static void DisplayItems(string name, params int[] item)
        {
            for (int i = 0; i < item.Length; i++)
            {
                Console.Write(item[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
