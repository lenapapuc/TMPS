using System;
using CreationalDesignPatterns.Builders;

namespace CreationalDesignPatterns.Structural_Design_Patterns.Composite
{
    public class FWBSimpleComponent : Component
    {
        Jeweler jewelryCreator = new Jeweler();
        public FWBSimpleComponent(string name) : base(name)
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
            jewelryCreator.CreateObject(new FWBBuilder());
            var jewel = jewelryCreator.GetJewelry();
            Console.WriteLine(new String('-', depth) + " " + jewel.name);
            Console.WriteLine(FreshWaterBracelet.GetDescription());
        }
    }
}