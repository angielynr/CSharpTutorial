using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritancePartialClass.Polymorphism.Operator_Overloading;

namespace InheritancePartialClass.Polymorphism.Operator_Overloading
{
    public static class OperationOverloading
    {

        public static void  OperatorOverloading()
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            Box Box3 = new Box();
            double volume = 0.0;

            //box1
            Box1.setLength(6.0);
            Box1.setWidth(7.0);
            Box1.setHeight(5.0);

            //box2
            Box2.setLength(6.0);
            Box2.setWidth(7.0);
            Box2.setHeight(5.0);

            //Box 1 volume
            volume = Box1.getVolume();
            Console.WriteLine("Box1 volume: {0}", volume);

            //Box 2 volume
            volume = Box2.getVolume();
            Console.WriteLine("Box2 volume: {0}", volume);

            Box3 = Box1 + Box2;
            volume = Box3.getVolume();
            Console.WriteLine("Box2 volume: {0}", volume);

            bool isItEqual = Box1 == Box2;
        }
        
    }
}
