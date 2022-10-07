using System;

namespace Geometry
{
    public class Circle : ShapeArea
    {
        //this class calculates the area of a circle
        public int Radius { get; set; }

        public override long Area()
        {
            long area = (long) (Radius * Radius * Math.PI);
            return area;
        }
    }
}