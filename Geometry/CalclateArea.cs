namespace Geometry
{
    public class CalculateArea
    {
        //this class is responsible for calculating the total area of all mentioned objects
        public double TotalArea(ShapeArea[] arrShapes)  
        {  
            double area = 0;
            
            foreach(var objArea in arrShapes)  
            {  
                area += objArea.Area();  
            }  
            return area;  
        }  
    }
}