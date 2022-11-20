using System;

namespace CreationalDesignPatterns
{
    public abstract class Jewelry
    {
        public String name { get; set; }
        public float price { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        
        public String engraving { get; set; }
        public abstract void WriteResponse();
    }
}