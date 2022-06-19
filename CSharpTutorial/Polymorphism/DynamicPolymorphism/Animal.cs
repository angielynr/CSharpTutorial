using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePartialClass.Polymorphism.DynamicPolymorphism
{
    internal class Animal
    {
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Inside base animal");
        }
    }
}
