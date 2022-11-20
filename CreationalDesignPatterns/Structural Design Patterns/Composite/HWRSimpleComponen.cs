using System;
using CreationalDesignPatterns.Builders;

namespace CreationalDesignPatterns.Structural_Design_Patterns.Composite
{
    public class HWRSimpleComponent : Component
    {
        Jeweler jewelryCreator = new Jeweler();
        public HWRSimpleComponent(string name) : base(name)
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
            jewelryCreator.CreateObject(new HWRBuilder());
            var jewel = jewelryCreator.GetJewelry();
            Console.WriteLine(new String('-', depth) + " " + jewel.name);
            Console.WriteLine(HardwearRing.GetDescription());
        }
    }
}