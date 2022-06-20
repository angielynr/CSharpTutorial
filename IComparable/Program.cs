using System;
using System.Collections.Generic;

namespace IComparableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> myPartyAges = new List<int> { 23, 24, 30, 31, 32, 34 };
            //myPartyAges.Sort();
            //foreach (var item in myPartyAges)
            //{
            //    Console.WriteLine(item);
            //}

            List<Cow> myCows = new List<Cow>
            {
                new Cow("Edwin"),
                new Cow("Chiz"),
                new Cow("Miguel"),
                new Cow("Angie"),
                new Cow("Reynard")
            };

            //myCows.Sort();
            //myCows.Reverse();
            //foreach (var item in myCows)
            //{
            //    Console.WriteLine($"{item.Name}: {item.Weight}");
            //}

            //myCows.Sort(new myCowComparer());
            myCows.Sort();
            foreach (var item in myCows)
            {
                Console.WriteLine($"{item.Name}: {item.Weight}");
            }
            Console.ReadLine();
        }
    }

    public class Cow : IComparable<Cow>
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public Random rand = new Random();

        public Cow(string name)
        {
            Name = name;
            Weight = rand.Next(500, 1000);
        }

        public int CompareTo(Cow other)
        {
            return Name.CompareTo(other.Name);
        }
    }

    public class myCowComparer : IComparer<Cow>
    {
        public int Compare(Cow x, Cow y)
        {
            return x.Weight.CompareTo(y.Weight);
        }

        
    }
}
