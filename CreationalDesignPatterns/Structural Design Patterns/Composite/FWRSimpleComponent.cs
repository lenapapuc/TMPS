using System;
using CreationalDesignPatterns.Builders;
using CreationalDesignPatterns.Structural_Design_Patterns.Composite;

namespace CreationalDesignPatterns.Structural_Design_Patterns
{
    public class FWRSimpleComponent : Component
    {
        Jeweler jewelryCreator = new Jeweler();
        public FWRSimpleComponent(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine( "Cannot Add");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot Remove");
        }

        public override void Display(int depth)
        {
            jewelryCreator.CreateObject(new FWRBuilder());
            var jewel = jewelryCreator.GetJewelry();
            Console.WriteLine(new String('-', depth) + " " + jewel.name);
            Console.WriteLine(FreshWaterRing.GetDescription());
        }
    }
}