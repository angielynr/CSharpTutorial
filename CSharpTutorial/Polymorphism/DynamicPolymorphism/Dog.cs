using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePartialClass.Polymorphism.DynamicPolymorphism
{
    internal class Dog : Animal
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Inside derived dog");
        }
    }
}
