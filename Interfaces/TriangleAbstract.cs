using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class TriangleAbstract : AbstractRegularPolygon
    {
        public TriangleAbstract(int length) : base(3, length)
        {

        }
        public override double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        }
    }
}
