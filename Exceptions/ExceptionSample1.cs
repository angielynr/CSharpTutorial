using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ExceptionSample1
    {
        public static void ExceptionsDemo()
        {
            int num1, num2;
            string operation;
            int result;

            Console.WriteLine("Enter 2 numbers");
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operation");
            operation = Console.ReadLine();



            try
            {
                result = Calculate(num1, num2, operation);
                Console.WriteLine($"Divide: {result.ToString()}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You have entered 0.");
                Console.WriteLine($"Details: {ex.ToString()}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Other Exception raised: {ex.ToString()}");
            }


            Console.ReadLine();
        }

        private static int Calculate(int num1, int num2, string operation)
        {
            if (operation == "/")
            {
                try
                {
                    return Divide(num1, num2);
                }
                catch (DivideByZeroException)
                {
                    throw;
                }
                catch (ArgumentNullException)
                {

                    throw;
                }
            }
            else
            {
                throw new CalculationException("Operation not yet implemented");
            }
        }

        private static int Divide(int number, int divisor) => number / divisor;

        public class CalculationException : System.Exception
        {
            private const string defaultMessage = "An error dyring calculation";
            public CalculationException() : base(defaultMessage)
            {

            }

            public CalculationException(string message) : base(message)
            {

            }

            public CalculationException(System.Exception innerException) : base(defaultMessage, innerException)
            {

            }
            public CalculationException(string message, System.Exception innerException) : base(message, innerException)
            {

            }
        }
    }
}
