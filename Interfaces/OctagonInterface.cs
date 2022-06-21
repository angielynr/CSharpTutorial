using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class OctagonInterface : ISpecialPolygon, IGetArea
    {

        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public OctagonInterface(int length)
        {
            NumberOfSides = 8;
            SideLength = length;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public double GetArea()
        {
            return SideLength * SideLength;
        }
    }

}
