using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class SquareConcrete : ConcreteRegularPolygon
    {
        public SquareConcrete(int length) : base(4, length) //base - provides value to base class
        {

        }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }

    }
}
