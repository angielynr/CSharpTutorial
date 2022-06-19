using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePartialClass.Polymorphism.DynamicPolymorphism
{
    internal class DynamicPolymorphism
    {
        public void DisplayAnimalInfo()
        {
            Animal obj1 = new Dog();
            Animal obj2 = new Cat();
            Dog obj3 = new Dog();
            obj1.DisplayInfo();
            obj2.DisplayInfo();
            obj3.DisplayInfo();
        }

    }
}
