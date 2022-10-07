using System.Drawing;

namespace Geometry
{
    public class RectangleDraw : ObjectDrawingProperties
    {
        //this class draws a rectangle
        public void Draw(RectangleArea rectangle)
        {
            Bitmap bitmap = new Bitmap(1000, 1000, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            Graphics graphics = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color, PenWidth);

            graphics.DrawRectangle(pen, 10, 10, rectangle.Width, rectangle.Height);
            bitmap.Save(@"C:\Users\User\RiderProjects\SOLID\Geometry\DrawRectangle.png");
        }
    }
}