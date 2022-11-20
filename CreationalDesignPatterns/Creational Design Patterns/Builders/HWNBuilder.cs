namespace CreationalDesignPatterns.Builders
{
    public class HWNBuilder : IJewelryBuilder
    {
        private HardwearNecklace _hardwearNecklace;

        public HWNBuilder() {this.Create();}
        public void Create()
        {
            _hardwearNecklace = new HardwearNecklace();
        }

        public void SetName()
        {
            _hardwearNecklace.name = "Ball Pendant";
        }

        public void SetType()
        {
            _hardwearNecklace.type = "Necklace";
        }

        public void SetPrice()
        {
            _hardwearNecklace.price = 500;
        }

        public Jewelry GetJewelry()
        {
            return _hardwearNecklace;
        }
        
        public void AddEngraving()
        {
            _hardwearNecklace.engraving = null;
        }
    }
}