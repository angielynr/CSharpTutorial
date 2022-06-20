using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var square = new SquareConcrete(5); //CONCRETECLASS
            DisplayPolygon("Square", square);

            //var square2 = new ConcreteRegularPolygon(4, 4); 
            //var square3 = new AbstractRegularPolygon(5, 5); !!!ABSTRACT! CANNOT INTANTIATE

            var triangle = new TriangleAbstract(5); //ABSTRACT CLASS, instantiated using derived class TRIANGLE
            DisplayPolygon("Triangle", triangle);

            var octagon = new OctagonInterface(5);
            DisplayPolygon("Octagon", octagon);

            

        }

        private static void DisplayPolygon(string polygonType, dynamic polygon) //dynamic - can accept any type.
        {
            Console.WriteLine($"{polygonType} Number of Side: {polygon.NumberOfSides}");
            Console.WriteLine($"{polygonType} Side Length: {polygon.SideLength}");
            Console.WriteLine($"{polygonType} Perimeter: {polygon.GetPerimeter()}");
            Console.WriteLine($"{polygonType} Number of Side: {polygon.GetArea()}");
            Console.WriteLine();
        }
    }
}
