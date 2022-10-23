using System;
using System.Dynamic;
using System.Runtime.InteropServices;
using CreationalDesignPatterns.Builders;

namespace CreationalDesignPatterns
{
    public class FreshWaterBracelet : Bracelet
    {
       
        public static String GetDescription()
        {
            return "Sleek sterling silver links are offset with lustrous pearls in this lock bracelet design.";
        }

        //public String description = GetDescription();
        public override void WriteResponse()
       {
           Console.WriteLine(name);
           Console.WriteLine(GetDescription());
           Console.WriteLine("Product: " + type + ";  Price: " + price + " $");
           Console.WriteLine(engraving);
           Console.WriteLine("********************************************************");
       }
        
    }
}