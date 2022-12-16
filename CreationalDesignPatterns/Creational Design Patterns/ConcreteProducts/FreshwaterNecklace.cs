using System;
using CreationalDesignPatterns.Behavioral_Design_Patterns;

namespace CreationalDesignPatterns
{
    public class FreshwaterNecklace : Necklace
    {
        public static String GetDescription()
        {
            return "A lustrous pearl drop takes center stage in this sterling silver wrap necklace.";
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
            visitor.Visit(this);
        }

    }
}