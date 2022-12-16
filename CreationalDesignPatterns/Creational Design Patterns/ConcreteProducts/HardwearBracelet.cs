using System;
using CreationalDesignPatterns.Behavioral_Design_Patterns;

namespace CreationalDesignPatterns
{
    public class HardwearBracelet : Bracelet
    {
        public int engravedPrice = 600;
        public static String GetDescription()
        {
            return "This sterling silver ball bracelet shines with every movement." +
                   "+ An everyday styling essential, this ball bracelet makes a statement when mixed with a stack of gold Tiffany bracelets.";
        }
        public override void WriteResponse()
       {
           Console.WriteLine(name);
           Console.WriteLine(GetDescription());
           Console.WriteLine("Product: " + type + ";  Price: " + price + " $");
           Console.WriteLine(engraving);
           Console.WriteLine("********************************************************");
       }

        public override void Accept(IVisitor visitor)
        {
            
        }

        
    }
}