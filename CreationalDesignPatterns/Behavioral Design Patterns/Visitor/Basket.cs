using System;
using System.Collections.Generic;

namespace CreationalDesignPatterns.Behavioral_Design_Patterns
{
    public class Basket
    {
        public static List<Jewelry> List = new List<Jewelry>();

        public void Attach(Jewelry jewelry)
        {
            List.Add(jewelry);
        }

        public void Delete(Jewelry jewelry)
        {
            List.Remove(jewelry);
        }
        
    }
}