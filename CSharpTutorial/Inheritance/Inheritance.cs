using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angie_CSharpTutorial.Inheritance
{
    internal class Inheritance
    {
        public void InheritanceDemo()
        {
            Rectangle rect = new Rectangle();
            rect.setHeight(2);
            rect.setWidth(2);
            rect.DisplayInfo();

            Console.WriteLine($"Total Rect Area: {rect.getArea()}");
        }
    }

    //Base class
    public class Shape
    {
        protected int width;
        protected int height;

        public void setWidth(int w)
        {
            width = w;
        }

        public void setHeight(int h)
        {
            height = h;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Display info is me");
        }
    }

    //Derived Class
    public class Rectangle : Shape
    {
        public int getArea()
        {
            return height * width;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Mwaaa rectable");
        }
    }
}
