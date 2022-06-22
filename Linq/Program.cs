using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SimpleDemo();
            //OfTypeDemo();
            //SelectManyDemo();
            //ZipDemo();
            //OrderByDemo();
            GroupByDemo();

            Console.ReadLine();
        }

        private static void GroupByDemo()
        {
            var groupByMethodSyntax = Student.GetStudents().GroupBy(s => s.BarType);

            foreach (var group in groupByMethodSyntax)
            {
                Console.WriteLine(group.Key + " : " + group.Count());

                foreach (var student in group)
                {
                    Console.WriteLine($"   Name:{student.Name}, Age:{student.Age}, Gender:{student.Gender}");
                }
            }
        }

        private static void OrderByDemo()
        {
            List<int> intList = new List<int>() { 3, 23, 34, 45, 34, 54, 87, 42, 75, 67 };

            Console.WriteLine("Before Sorting");
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("After Sorting");

            var ms = intList.OrderBy(num => num);
            var qs = (from num in intList
                      orderby num
                      select num).ToList();


            foreach (var item in qs)
            {
                Console.Write(item + " ");
            }

            var descending = intList.OrderByDescending(num => num);
            var reverse = intList.ToArray().Reverse();
            foreach (var item in reverse)
            {
                Console.Write(item + " ");
            }
        }

        private static void ZipDemo()
        {
            int[] numbersSequence = { 10, 20, 30, 40, 50 };
            string[] wordSequence = { "ten", "twenty", "thirty", "forty" };

            var resultSequence = numbersSequence.Zip(wordSequence, (first, second) => first + " - " + second);

            foreach (var result in resultSequence) { Console.WriteLine(result); }
        }

        private static void SelectManyDemo()
        {
            List<string> animals = new List<string>() { "cat", "dog", "donkey" };
            List<int> number = new List<int>() { 1, 2, 3, 4 };

            var mix = number.SelectMany(num => animals, (n, a) => new { n, a });

            foreach (var item in mix)
            {
                Console.WriteLine($"{item.n}: {item.a}");
            }
        }

        private static void OfTypeDemo()
        {
            ArrayList fruits = new ArrayList() { "Mango", "Orange", 2, true, 6.1, "Banana", 4 };

            var stringFruits = fruits.OfType<string>().ToList();
            var intMyNumbers = fruits.OfType<int>().ToList();

            foreach (var item in intMyNumbers)
            {
                Console.WriteLine(item);
            }
        }

        private static void SimpleDemo()
        {
            var result = GenerateNumbers(10).Where(n => n % 2 == 0);

            var result2 = GenerateNumbers(10)
                .Where(n =>
                {
                    return n % 2 == 0;
                })
                .Select(n =>
                {
                    return n * 3;
                });

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static IEnumerable<int> GenerateNumbers(int maxValue)
        {
            var result = new List<int>();
            for (int i = 0; i < maxValue; i++)
            {
                result.Add(i);
            }

            return result;
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string BarType { get; set; }
        public int Age { get; set; }

        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student { ID = 101, Name = "Angie", Gender = "Female", BarType = "ABC", Age = 12},
                new Student { ID = 102, Name = "Edwin", Gender = "Female", BarType = "CSE", Age = 23},
                new Student { ID = 103, Name = "Chiz", Gender = "Male", BarType = "CSE", Age = 44},
                new Student { ID = 104, Name = "Miguel", Gender = "Female", BarType = "ABC", Age = 23},
                new Student { ID = 105, Name = "Marlon", Gender = "Male", BarType = "CSE", Age = 23},
                new Student { ID = 106, Name = "Kevin", Gender = "Female", BarType = "ABC", Age = 54},
                new Student { ID = 107, Name = "Reynard", Gender = "Female", BarType = "ABC", Age = 55},
                new Student { ID = 108, Name = "Marc", Gender = "Male", BarType = "SDA", Age = 23},
                new Student { ID = 109, Name = "Ghel", Gender = "Female", BarType = "CSE", Age = 122},
                new Student { ID = 1010, Name = "Maggie", Gender = "Female", BarType = "CSE", Age = 23}
            };
        }
    }
}
