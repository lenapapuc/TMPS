using System;

namespace CreationalDesignPatterns
{
    public abstract class JewelryFactory
    {
        public abstract Bracelet GetBracelet();
        public abstract Necklace GetNecklace();
        public abstract Ring GetRing();

        public abstract JewelryFactory Clone();
    }
}