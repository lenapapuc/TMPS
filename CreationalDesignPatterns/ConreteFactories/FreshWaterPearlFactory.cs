using System;
using CreationalDesignPatterns.Builders;

namespace CreationalDesignPatterns
{
    public class FreshWaterPearlFactory : JewelryFactory
    {
        private static FreshWaterPearlFactory _freshWaterPearlFactory;
        protected FreshWaterPearlFactory()
        {
        }

        public static FreshWaterPearlFactory Instance()
        {
            if (_freshWaterPearlFactory == null) _freshWaterPearlFactory = new FreshWaterPearlFactory();
            return _freshWaterPearlFactory;
        }
        
        Jeweler jewelryCreator = new Jeweler();
        public override Bracelet GetBracelet()
        {
            jewelryCreator.CreateObject(new FWBBuilder());
            var jewel = jewelryCreator.GetJewelry();
            return (Bracelet) jewel;
        }

        public override Necklace GetNecklace()
        {
            jewelryCreator.CreateObject(new FWNBuilder());
            var jewel = jewelryCreator.GetJewelry();
            return (Necklace) jewel;
        }

        public override Ring GetRing()
        {
            jewelryCreator.CreateObject(new FWRBuilder());
            var jewel = jewelryCreator.GetJewelry();
            return (Ring) jewel;
        }

        public override JewelryFactory Clone()
        {
            return (JewelryFactory) this.MemberwiseClone();
        }
    }
}