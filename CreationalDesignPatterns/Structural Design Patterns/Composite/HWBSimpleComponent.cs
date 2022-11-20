using System;
using CreationalDesignPatterns.Builders;

namespace CreationalDesignPatterns.Structural_Design_Patterns.Composite
{
    public class HWBSimpleComponent : Component
    {
        Jeweler jewelryCreator = new Jeweler();
        public HWBSimpleComponent(string name) : base(name)
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
            jewelryCreator.CreateObject(new HWBBuilder());
            var jewel = jewelryCreator.GetJewelry();
            Console.WriteLine(new String('-', depth) + " " + jewel.name);
            Console.WriteLine(HardwearBracelet.GetDescription());
        }
    }
}