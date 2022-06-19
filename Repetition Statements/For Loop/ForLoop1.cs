using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Statements.For_Loop
{
    internal static class ForLoop1
    {
        public static void ForLoop1Sample()
        {
            Console.WriteLine("This program will let you enter a value per value.");
            Console.WriteLine("Enter 0 to exit");


            for (string? userInput = ""; userInput != "0"; userInput = Console.ReadLine())
            {
                Console.WriteLine("Enter value (0 to exit)");
            }
        }
    }
}
