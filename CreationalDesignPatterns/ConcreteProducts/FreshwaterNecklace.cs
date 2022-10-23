using System;

namespace CreationalDesignPatterns
{
    public class FreshwaterNecklace : Necklace
    {
        public String GetDescription()
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
       
    }
}