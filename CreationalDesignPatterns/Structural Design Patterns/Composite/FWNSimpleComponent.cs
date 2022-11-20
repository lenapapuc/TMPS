using System;
using CreationalDesignPatterns.Builders;

namespace CreationalDesignPatterns.Structural_Design_Patterns.Composite
{
    public class FWNSimpleComponent : Component
    {
        Jeweler jewelryCreator = new Jeweler();
        public FWNSimpleComponent(string name) : base(name)
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
            jewelryCreator.CreateObject(new FWNBuilder());
            var jewel = jewelryCreator.GetJewelry();
            Console.WriteLine(new String('-', depth) + " " + jewel.name);
            Console.WriteLine(FreshwaterNecklace.GetDescription());
        }
    }
}