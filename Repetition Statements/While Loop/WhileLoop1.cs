using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Statements.While_Loop
{
    internal class WhileLoop1
    {
        public static void WhileLoop1Sample()
        {
            string? valueInput = "";

            while (valueInput != "0")
            {
                Console.WriteLine("Enter value: (0 to exit loop)");
                valueInput = Console.ReadLine();
            }
            Console.WriteLine("You entered 0. Thank you! Bye!");
        }
    }
}
