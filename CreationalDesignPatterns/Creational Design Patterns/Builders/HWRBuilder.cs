namespace CreationalDesignPatterns.Builders
{
    public class HWRBuilder : IJewelryBuilder
    {
        private HardwearRing _hardwearRing;

        public HWRBuilder() {this.Create();}
        public void Create()
        {
            _hardwearRing = new HardwearRing();
        }

        public void SetName()
        {
            _hardwearRing.name = "Ball Ring";
        }

        public void SetType()
        {
            _hardwearRing.type = "Ring";
        }

        public void SetPrice()
        {
            _hardwearRing.price = 225;
        }

        public Jewelry GetJewelry()
        {
            return _hardwearRing;
        }
        
        public void AddEngraving()
        {
            _hardwearRing.engraving = null;
        }
    }
}