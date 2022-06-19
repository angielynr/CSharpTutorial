using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Statements.ForEachLoop
{
    internal class ForEach1
    {
        public static void ForEach1Sample()
        {
            int[] numbers = { 1, 2, 3, 43, 5, 54 };

            //Using For Each
            Console.WriteLine("Using For Each------");
            foreach (int item in numbers)
            {
                
                Console.WriteLine(item);
            }

            //Using For Loop
            Console.WriteLine("Using For Loop-------");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //Using While Loop
            int x = 0;
            Console.WriteLine("Using For Loop-------");
            while ( x < numbers.Length)
            {
                Console.WriteLine(numbers[x]);
                x++;
            }

        }
    }
}
