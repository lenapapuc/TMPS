using CreationalDesignPatterns.Builders;

namespace CreationalDesignPatterns
{
    public class HardwearBallFactory : JewelryFactory
    {
        private static HardwearBallFactory hardwearBallFactory;
        protected HardwearBallFactory()
        {
        }

        public static HardwearBallFactory Instance()
        {
            if (hardwearBallFactory == null) hardwearBallFactory = new HardwearBallFactory();
            return hardwearBallFactory;
        }
        Jeweler jewelryCreator = new Jeweler();
        public override Bracelet GetBracelet()
        {
            jewelryCreator.CreateObject(new HWBBuilder());
            var jewel = jewelryCreator.GetJewelry();
            return (Bracelet) jewel;
        }

        public override Necklace GetNecklace()
        {
            jewelryCreator.CreateObject(new HWNBuilder());
            var jewel = jewelryCreator.GetJewelry();
            return (Necklace) jewel;
        }

        public override Ring GetRing()
        {
            jewelryCreator.CreateObject(new HWRBuilder());
            var jewel = jewelryCreator.GetJewelry();
            return (Ring) jewel;
        }

        public override JewelryFactory Clone()
        {
            return (JewelryFactory)this.MemberwiseClone();
        }
    }
}