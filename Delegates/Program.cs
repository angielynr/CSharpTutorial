using System;

namespace Delegates
{
    internal class Program
    {
        //Delegate
        public delegate void MessageDelegate(string mesage);

        //MAIN
        static void Main(string[] args)
        {
            MessageDelegate handler = DelegateMethod;
            handler("Hello World");

            DelegateMethod("Hellow World!");

            MethodWithCallback(3, 5, handler);

            var obj = new MethodClass();
            MessageDelegate d1 = obj.Method1;
            MessageDelegate d2 = obj.Method2;
            MessageDelegate d3 = DelegateMethod;
            MessageDelegate d4 = delegate (string message)
            {
                Console.WriteLine($"{message} from anonymous method");
            };

            MessageDelegate allMethodsDelegate = d1 + d2;
            allMethodsDelegate += d3;
            allMethodsDelegate += d4;

            var invokeList = allMethodsDelegate.GetInvocationList(); //Array of delegates
            foreach (var method in invokeList)
            {
                method.DynamicInvoke("Hello");
            }

            allMethodsDelegate -= DelegateMethod;
            invokeList = allMethodsDelegate.GetInvocationList();
            foreach (var method in invokeList)
            {
                method.DynamicInvoke("Hello");
            }

            //ACTION
            Action<string> d5 = (message) => Console.WriteLine($"{message} from Action delegate using Lambda expression");

            //allMethodsDelegate += d5;
            d5("Hello");

            //FUNC
            Func<string, string> d6 = (message) =>
            {
                return $"{message} from Action FUNC delegate using Lambda expression";
            };
            var result = d6("Hello");
            Console.WriteLine(result);

            Predicate<string> isUpper = IsUpperCase;
            bool resultToUpper = isUpper("hello world result to upper");
            Console.WriteLine($"Hello world is upper? {resultToUpper}");

            //PREDICATE
            static bool IsUpperCase(string str)
            {
                return str.Equals(str.ToUpper());
            }
        }

        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void MethodWithCallback(int param1, int param2, MessageDelegate callback)
        {
            callback($"The number is {param1 + param2}.");
        }
    }

    public class MethodClass
    {
        public void Method1(string message) { Console.WriteLine($"{message} from Method1"); }
        public void Method2(string message) { Console.WriteLine($"{message} from Method2"); }

    }
}
