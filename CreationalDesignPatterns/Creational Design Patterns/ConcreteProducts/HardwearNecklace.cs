using System;

namespace CreationalDesignPatterns
{
    public class HardwearNecklace : Necklace
    {
        public static String GetDescription()
        {
            return "Featuring a sleek sterling silver ball, this simple pendant is effortlessly modern and timeless.";
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