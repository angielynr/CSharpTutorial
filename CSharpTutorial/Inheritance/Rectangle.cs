using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePartialClass.Inheritance
{
        //Derived Class
      public class Rectangle : Shape
        {
            public int getArea()
            {
                return height * width;
            }

            //public override void DisplayInfo()
            //{
            //    Console.WriteLine("Mwaaa rectable");
            //}
      }
    
}
