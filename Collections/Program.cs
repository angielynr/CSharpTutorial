using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayListDemo();
            //DictionariessDemo();
            //QueuesDemo();
            //StackDemo();
            ListDemo();

            Console.ReadLine();
        }

        private static void ListDemo()
        {
            List<int> myFamilyAge = new List<int>() { 50, 81, 22, 13 };
            myFamilyAge.Add(36);

            foreach (var item in myFamilyAge)
            {
                Console.WriteLine(item);
            }

            List<Car> myFavoriteCar = new List<Car>();

            //myFamilyAge.
        }

        private static void StackDemo()
        {
            //anotherMethod();

            Stack<string> stack = new Stack<string>();
            stack.Push("Main");
            stack.Push("anotherMethod");
            stack.Push("anotherMethod2");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"1 in Queue: {stack.Peek()}");

            var nextValue = stack.Pop();
            Console.WriteLine($"Current Handled item: {nextValue}");

            Console.WriteLine();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        private static void anotherMethod()
        {
            anotherMethod2();
        }

        private static void anotherMethod2()
        {
            throw new NotImplementedException();
        }

        private static void QueuesDemo()
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("one");
            queue.Enqueue("two");
            queue.Enqueue("three");

            Console.WriteLine($"1 in Queue: {queue.Contains("one")}");

            queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"1 in Queue: {queue.Contains("one")}");
            Console.WriteLine($"1 in Queue: {queue.Peek()}");

            var myQueueArray = queue.ToArray();

            //Queue<Car> queueCar = new Queue<string>();


        }

        private static void DictionariessDemo()
        {
            Dictionary<string, string> superheroes = new Dictionary<string, string>();
            superheroes.Add("Superman", "Clark Kent");
            superheroes.Add("fd", "Clark re");
            superheroes.Add("gfd", "Clark fgdg");

            foreach (var item in superheroes)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.WriteLine($"Count: {superheroes.Count}");
            Console.WriteLine($"sda: {superheroes.ContainsKey("Superman")}");

            Car car1 = new Car();
            car1.Make = "Toyota";
            car1.Model = "Corolla";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Honda";
            car2.Model = "Civic";
            car2.VIN = "B2";

            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            foreach (var item in myDictionary)
            {
                var make = (item.Value).Make;
                Console.WriteLine($"{item.Key}: {(item.Value).Make}");
            }
        }
        
        public class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public string VIN { get; set; }
        }

        private static void ArrayListDemo()
        {
            ArrayList aList = new ArrayList();
            aList.Add(1);
            aList.Add("Cow");
            aList.Add("Cow");
            aList.Add("Cow");
            aList.Add("Cow");
            aList.Add("Cow");
            aList.Add("Cow");
            aList.Add(true);
            aList.Add(true);
            aList.Add(true);
            aList.Add(true);

            Console.WriteLine($"Count: {aList.Count}");
            Console.WriteLine($"Count: {aList.Capacity}");

            ArrayList aList2 = new ArrayList();

            aList2.AddRange(new object[] {"Edwin", 50, 5.5, 5.44334});
            aList2.AddRange(aList2);

            Console.WriteLine($"Count: {aList2.Count}");
            Console.WriteLine($"Count: {aList2.Capacity}");

            //aList.Sort();
            //aList2.Reverse();

            aList2.Insert(1, "Manila");

            foreach (object item in aList)
            {
                Console.WriteLine(item);
            }

            ArrayList stringList = new ArrayList() { "one", "two", "three"};
            string[] myNumbers = (string[])stringList.ToArray(typeof(string));

            Console.WriteLine();
            foreach (var item in myNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
