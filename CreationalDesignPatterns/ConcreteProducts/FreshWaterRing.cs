using System;

namespace CreationalDesignPatterns
{
    public class FreshWaterRing : Ring
    {
        public String GetDescription()
        {
            return "Two bold bands of sterling silver exude modern sophistication in this double ring design.";
        }

        public override void WriteResponse()
        {
            Console.WriteLine(name);
            Console.WriteLine(GetDescription());
            Console.WriteLine("Product: " + type + ";  Price: " + price + " $");
            Console.WriteLine("********************************************************");
        }
     
    }
}