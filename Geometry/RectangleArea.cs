using System;
using System.Drawing;
using System.Security.Cryptography;
using Aspose.Drawing;

namespace Geometry
{
    public class RectangleArea : ShapeArea
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public override long Area()
        {
            long area = Height * Width;
            return area;
        }
    }
}