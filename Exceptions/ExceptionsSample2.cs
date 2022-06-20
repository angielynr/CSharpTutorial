using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ExceptionsSample2
    {
        public static void SimpleOperation()
        {
            int num1;
            int num2;
            int result;

       
            try
            {
                Console.WriteLine("Enter first number:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                num2 = Convert.ToInt32(Console.ReadLine());

                result = num1 / num2;
                Console.WriteLine("Result: {0}", result);
            }
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally //Get executed no matter what
            {

            }
        }
    }
}
