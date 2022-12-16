using System;
using CreationalDesignPatterns.Behavioral_Design_Patterns;
using CreationalDesignPatterns.Builders;

namespace CreationalDesignPatterns
{
    public abstract class Jewelry : IElement
    {
        public String name { get; set; }
        public float price { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        
        public String engraving { get; set; }
        public abstract void WriteResponse();


        public abstract void Accept(IVisitor visitor);
    }
}