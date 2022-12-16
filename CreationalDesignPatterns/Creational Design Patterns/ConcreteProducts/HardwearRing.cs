using System;
using CreationalDesignPatterns.Behavioral_Design_Patterns;

namespace CreationalDesignPatterns
{
    public class HardwearRing : Ring
    {
        public static String GetDescription()
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

         public override void Accept(IVisitor visitor)
         {
             throw new NotImplementedException();
         }
    }
}