using System.Drawing;
namespace Geometry
{
    public class DrawCircle : ObjectDrawingProperties
    {
        //this class draws a circle
        public void Draw(Circle circle)
        {
            Bitmap bitmap = new Bitmap(1000, 800, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            Graphics graphics = Graphics.FromImage(bitmap);

            Pen pen = new Pen(Color, PenWidth);
            graphics.DrawEllipse(pen, 10, 10, circle.Radius, circle.Radius);

            bitmap.Save(@"C:\Users\User\RiderProjects\SOLID\Geometry\DrawCircle.png");
        }
    }
}