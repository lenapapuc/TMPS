using System;
using System.Drawing;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            
            RectangleArea obj1 = new RectangleArea();
            obj1.Height = 800;
            obj1.Width = 900;
            
            Circle obj2 = new Circle();
            obj2.Radius = 700;
            
            CalculateArea calculator = new CalculateArea();
            Console.WriteLine(calculator.TotalArea(new ShapeArea[] {obj1, obj2}));
            
            RectangleDraw rectangleDraw = new RectangleDraw();
            rectangleDraw.Color = Color.Olive;
            rectangleDraw.PenWidth = 2;
            rectangleDraw.Draw(obj1);
            
            DrawCircle drawCircle = new DrawCircle();
            drawCircle.Color = Color.Firebrick;
            drawCircle.PenWidth = 23;
            drawCircle.Draw(obj2);
            
            

        }
    }
}