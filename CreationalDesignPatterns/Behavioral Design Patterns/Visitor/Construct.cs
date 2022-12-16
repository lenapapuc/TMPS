using System;
using CreationalDesignPatterns.Builders;

namespace CreationalDesignPatterns.Behavioral_Design_Patterns
{
    public class Construct : IVisitor
    {
        public Basket _basket = new Basket();

        public void Visit(FreshWaterBracelet bracelet)
        {
            Jeweler jeweler = new Jeweler();
            jeweler.CreateObject(new FWBBuilder());
            Bracelet b = (Bracelet) jeweler.GetJewelry();
            _basket.Attach(b);
            Console.WriteLine($"{b.name} was added to the basket");
        }

        public void Visit(FreshwaterNecklace necklace)
        {
            Jeweler jeweler = new Jeweler();
            jeweler.CreateObject(new FWNBuilder());
            Necklace b = (Necklace) jeweler.GetJewelry();
            _basket.Attach(b);
            Console.WriteLine($"{b.name} was added to the basket");
        }

        public void Visit(FreshWaterRing ring)
        {
            Jeweler jeweler = new Jeweler();
            jeweler.CreateObject(new FWRBuilder());
            Ring b = (Ring) jeweler.GetJewelry();
            _basket.Attach(b);
            Console.WriteLine($"{b.name} was added to the basket");
        }
    }
}